using System.Diagnostics.Tracing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.Sockets
{
    public class SyncSocketStream<TPacketSeparator> : SocketStream<TPacketSeparator> where TPacketSeparator : IPacketSeparator, new()
    {
        private CancellationTokenSource cancellationTokenSource;

        public override Socket Socket
        {
            get
            {
                return base.Socket;
            }
            set
            {
                base.Socket = value;
                if (Socket == null)
                {
                    return;
                }

                logCallback?.Invoke(EventLevel.Verbose, $"Index = {base.Id}; Start Task for receiving loop...", null);
                Task.Factory.StartNew(delegate
                {
                    try
                    {
                        base.State = StreamState.Connected;
                        cancellationTokenSource = new CancellationTokenSource();
                        ReceivingLoop();
                    }
                    catch (Exception arg)
                    {
                        logCallback?.Invoke(EventLevel.Warning, "Receiving loop task", arg);
                    }
                });
            }
        }

        public SyncSocketStream(Action<EventLevel, string, Exception> logCallback = null)
            : base(logCallback)
        {
        }

        private void ReceivingLoop()
        {
            logCallback?.Invoke(EventLevel.Verbose, $"Index = {base.Id}; Receiving loop started...", null);
            while (true)
            {
                CancellationTokenSource obj = cancellationTokenSource;
                if (obj == null || obj.IsCancellationRequested)
                {
                    break;
                }

                try
                {
                    logCallback?.Invoke(EventLevel.Verbose, $"Index = {base.Id}; Before receiving...", null);
                    int? num = Socket?.Receive(buffer);
                    logCallback?.Invoke(EventLevel.Verbose, $"Index = {base.Id}; After receiving... Data length = {num ?? 0}", null);
                    if (!ProcessBuffer(num ?? 0))
                    {
                        cancellationTokenSource?.Cancel();
                    }
                }
                catch (SocketException exception)
                {
                    Disconnect(exception);
                }
                catch (Exception arg)
                {
                    logCallback?.Invoke(EventLevel.Warning, "ReceivingLoop", arg);
                }
            }
        }

        public override void Connect(EndPoint endPoint)
        {
            base.Connect(endPoint);
            base.State = StreamState.Connecting;
            Socket socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endPoint);
            Socket = socket;
        }

        public override void Disconnect(Exception exception = null)
        {
            cancellationTokenSource?.Cancel();
            base.Disconnect(exception);
        }

        protected override void SendDataAction(byte[] data)
        {
            if (base.State == StreamState.Connected)
            {
                Socket obj = Socket;
                if (obj != null && obj.Connected)
                {
                    Socket?.Send(data);
                }
            }
        }
    }
}
