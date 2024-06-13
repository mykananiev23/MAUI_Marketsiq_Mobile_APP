using System.Diagnostics.Tracing;
using System.Net;
using System.Net.Sockets;
using MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.Sockets
{
    public abstract class SocketNetworkConnector<TPacketSeparator> : INetworkConnector, IDisposable where TPacketSeparator : IPacketSeparator, new()
    {
        protected Socket ListenerSocket;

        private readonly ISocketStream[] streamsBuffer;

        private readonly CancellationTokenSource listenerTokenSource;

        protected readonly Action<EventLevel, string, Exception> LogCallback;

        private int onlineClientsCounter;

        public int OnlineClients { get; private set; }

        public virtual int IncomingConnectionsQueueDepth => 0;

        public event EventHandler<StreamEventArgs> StreamConnected;

        public event EventHandler<StreamEventArgs> StreamDataReceived;

        public event EventHandler<StreamEventArgs> StreamStateChanged;

        protected SocketNetworkConnector(int maxConnectionsCount, Action<EventLevel, string, Exception> logCallback = null)
        {
            LogCallback = logCallback;
            listenerTokenSource = new CancellationTokenSource();
            streamsBuffer = new ISocketStream[maxConnectionsCount];
            for (int i = 0; i < maxConnectionsCount; i++)
            {
                ISocketStream socketStream = CreateStream(i);
                streamsBuffer[i] = socketStream;
                socketStream.DataReceived += StreamOnDataReceived;
                socketStream.StateChanged += StreamOnStateChanged;
            }
        }

        protected abstract ISocketStream CreateStream(int index);

        protected abstract void AcceptConnection();

        protected void BindStreamWithSocket(ISocketStream stream, Socket clientSocket, int index)
        {
            if (stream != null)
            {
                stream.Socket = clientSocket;
                OnlineClients = Interlocked.Increment(ref onlineClientsCounter);
                LogCallback?.Invoke(EventLevel.Informational, $"Index = {index}; Client accepted. IP: {clientSocket.RemoteEndPoint} Total clients: {OnlineClients}", null);
                this.StreamConnected?.Invoke(stream, new StreamEventArgs(stream.State, index));
            }
            else
            {
                LogCallback?.Invoke(EventLevel.Warning, $"Clients max count ({streamsBuffer.Length}) has been reached.", null);
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }

        protected ISocketStream FindAvailableStream(out int index)
        {
            index = -1;
            for (int i = 0; i < streamsBuffer.Length; i++)
            {
                ISocketStream socketStream = streamsBuffer[i];
                if (socketStream.Socket == null)
                {
                    index = i;
                    return socketStream;
                }
            }

            return null;
        }

        private void ListenerSocketLoop()
        {
            try
            {
                ListenerSocket.Listen(streamsBuffer.Length);
                while (true)
                {
                    try
                    {
                        if (listenerTokenSource.IsCancellationRequested)
                        {
                            break;
                        }

                        AcceptConnection();
                    }
                    catch (Exception arg)
                    {
                        LogCallback?.Invoke(EventLevel.Warning, "ListenerSocketLoop", arg);
                    }
                }
            }
            catch (Exception arg2)
            {
                LogCallback?.Invoke(EventLevel.Warning, "ListenerSocketLoop", arg2);
            }
        }

        public virtual void Initialize(EndPoint endPoint)
        {
            ListenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ListenerSocket.Bind(endPoint);
            LogCallback?.Invoke(EventLevel.Informational, $"Socket opened on {endPoint}", null);
            Task.Factory.StartNew(ListenerSocketLoop, TaskCreationOptions.LongRunning);
        }

        public void Disconnect(int connectionIndex, string reason)
        {
            try
            {
                ISocketStream socketStream = streamsBuffer[connectionIndex];
                if (socketStream.State != StreamState.Disconnected)
                {
                    LogCallback?.Invoke(EventLevel.Informational, $"Index = {connectionIndex}; Begin disconnect. Reason: {reason}", null);
                    socketStream.Disconnect();
                }
            }
            catch (Exception arg)
            {
                LogCallback?.Invoke(EventLevel.Warning, "Disconnect", arg);
            }
        }

        public void SendData(byte[] message, int connectionIndex)
        {
            try
            {
                streamsBuffer[connectionIndex].SendData(message);
            }
            catch (Exception arg)
            {
                LogCallback?.Invoke(EventLevel.Warning, "SendData", arg);
            }
        }

        public virtual void Dispose()
        {
            listenerTokenSource.Cancel();
            for (int i = 0; i < streamsBuffer.Length; i++)
            {
                try
                {
                    if (streamsBuffer[i].Socket != null)
                    {
                        Disconnect(i, "Disposing");
                    }
                }
                catch (Exception arg)
                {
                    LogCallback?.Invoke(EventLevel.Warning, "Dispose", arg);
                }
            }
        }

        private void StreamOnDataReceived(object sender, StreamEventArgs e)
        {
            this.StreamDataReceived?.Invoke(sender, e);
        }

        private void StreamOnStateChanged(object sender, StreamEventArgs e)
        {
            if (e.StreamState == StreamState.Disconnected)
            {
                OnlineClients = Interlocked.Decrement(ref onlineClientsCounter);
            }

            this.StreamStateChanged?.Invoke(sender, e);
        }
    }
}
