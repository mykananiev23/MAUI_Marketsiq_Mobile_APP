using System.Diagnostics.Tracing;
using System.Net;
using System.Net.Sockets;
using MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.Sockets
{
    public abstract class SocketStream<TPacketSeparator> : ISocketStream, IStream where TPacketSeparator : IPacketSeparator, new()
    {
        private StreamState state;

        private Socket socket;

        protected const int BUFFER_SIZE = 8192;

        protected readonly byte[] buffer;

        private readonly MemoryStream memoryStream;

        private readonly TPacketSeparator packetSeparator;

        protected readonly Action<EventLevel, string, Exception> logCallback;

        public int Id { get; internal set; }

        public StreamState State
        {
            get
            {
                return state;
            }
            set
            {
                if (state != value)
                {
                    state = value;
                    this.StateChanged?.Invoke(this, new StreamEventArgs(State, Id));
                }
            }
        }

        public virtual Socket Socket
        {
            get
            {
                return socket;
            }
            set
            {
                socket = value;
            }
        }

        public event EventHandler<StreamEventArgs> StateChanged;

        public event EventHandler<StreamEventArgs> DataReceived;

        protected SocketStream(Action<EventLevel, string, Exception> logCallback = null)
        {
            this.logCallback = logCallback;
            packetSeparator = new TPacketSeparator();
            buffer = new byte[8192];
            memoryStream = new MemoryStream();
        }

        public virtual void Connect(EndPoint endPoint)
        {
            if (Socket != null)
            {
                throw new InvalidOperationException("Socket already exists");
            }
        }

        public virtual void Disconnect(Exception exception = null)
        {
            try
            {
                if (exception != null)
                {
                    logCallback?.Invoke(EventLevel.Warning, "OnDisconnect", exception);
                }

                if (State != StreamState.Disconnected)
                {
                    State = StreamState.Disconnected;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
            }
            catch (Exception arg)
            {
                logCallback?.Invoke(EventLevel.Warning, "Disconnect", arg);
            }
            finally
            {
                socket = null;
                memoryStream.SetLength(0L);
            }
        }

        public void SendData(byte[] data)
        {
            try
            {
                if (State != StreamState.Disconnected)
                {
                    SendDataAction(data);
                }
            }
            catch (SocketException exception)
            {
                Disconnect(exception);
            }
            catch (Exception arg)
            {
                logCallback?.Invoke(EventLevel.Warning, "SendData", arg);
            }
        }

        protected abstract void SendDataAction(byte[] data);

        protected bool ProcessBuffer(int dataLength)
        {
            if (dataLength == 0)
            {
                Disconnect();
                return false;
            }

            memoryStream.Position = memoryStream.Length;
            memoryStream.Write(buffer, 0, dataLength);
            memoryStream.Position = 0L;
            int headerLength = packetSeparator.HeaderLength;
            while (memoryStream.Length - memoryStream.Position >= headerLength)
            {
                byte[] header = new byte[headerLength];
                memoryStream.Read(header, 0, headerLength);
                memoryStream.Position -= headerLength;
                int packetLength = packetSeparator.GetPacketLength(header);
                logCallback?.Invoke(EventLevel.Verbose, $"Index = {Id}; Incoming message length = {packetLength}", null);
                if (memoryStream.Position + packetLength > memoryStream.Length)
                {
                    logCallback?.Invoke(EventLevel.Verbose, $"Index = {Id}; Not all bytes receive...waiting...", null);
                    break;
                }

                byte[] array = new byte[packetLength];
                memoryStream.Read(array, 0, array.Length);
                OnDataReceived(array, array.Length);
            }

            if (memoryStream.Position < memoryStream.Length)
            {
                byte[] array2 = new byte[memoryStream.Length - memoryStream.Position];
                memoryStream.Read(array2, 0, array2.Length);
                memoryStream.SetLength(0L);
                memoryStream.Write(array2, 0, array2.Length);
            }
            else
            {
                memoryStream.SetLength(0L);
            }

            return true;
        }

        private void OnDataReceived(byte[] data, int dataLength)
        {
            this.DataReceived?.Invoke(this, new StreamEventArgs(State, Id, data, dataLength));
        }
    }
}
