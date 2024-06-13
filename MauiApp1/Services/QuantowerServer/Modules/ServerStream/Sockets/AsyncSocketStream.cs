using System.Diagnostics.Tracing;
using System.Net;
using System.Net.Sockets;
using MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.Sockets
{
    public class AsyncSocketStream<TPacketSeparator> : SocketStream<TPacketSeparator> where TPacketSeparator : IPacketSeparator, new()
    {
        private readonly ManualResetEventSlim connectDone;

        public override Socket Socket
        {
            get
            {
                return base.Socket;
            }
            set
            {
                base.Socket = value;
                if (Socket != null)
                {
                    Socket.BeginReceive(buffer, 0, 8192, SocketFlags.None, ReceiveData, null);
                    base.State = StreamState.Connected;
                }
            }
        }

        public AsyncSocketStream(Action<EventLevel, string, Exception> logCallback = null)
            : base(logCallback)
        {
            connectDone = new ManualResetEventSlim(initialState: false);
        }

        public override void Connect(EndPoint endPoint)
        {
            base.Connect(endPoint);
            connectDone.Reset();
            base.State = StreamState.Connecting;
            Socket socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.BeginConnect(endPoint, ConnectCallback, socket);
            connectDone.Wait();
            base.State = StreamState.Connected;
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                if (ar.AsyncState is Socket socket)
                {
                    socket.EndConnect(ar);
                    Socket = socket;
                }
            }
            catch (Exception)
            {
                Disconnect();
            }
        }

        public override void Disconnect(Exception exception = null)
        {
            if (base.State != StreamState.Disconnected)
            {
                connectDone.Set();
                base.Disconnect(exception);
            }
        }

        protected override void SendDataAction(byte[] data)
        {
            if (base.State == StreamState.Connected)
            {
                Socket obj = Socket;
                if (obj != null && obj.Connected)
                {
                    Socket?.BeginSend(data, 0, data.Length, SocketFlags.None, SendDataCallback, null);
                }
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            try
            {
                int dataLength = Socket.EndReceive(asyncResult);
                ProcessBuffer(dataLength);
            }
            catch (SocketException)
            {
                Disconnect();
            }
            catch (Exception arg)
            {
                logCallback?.Invoke(EventLevel.Warning, "ReceiveData", arg);
            }
            finally
            {
                connectDone.Set();
                if (base.State != StreamState.Disconnected)
                {
                    Socket.BeginReceive(buffer, 0, 8192, SocketFlags.None, ReceiveData, null);
                }
            }
        }

        private void SendDataCallback(IAsyncResult asyncResult)
        {
            try
            {
                Socket?.EndSend(asyncResult);
            }
            catch (SocketException)
            {
                Disconnect();
            }
            catch (Exception arg)
            {
                logCallback?.Invoke(EventLevel.Warning, "SendDataCallback", arg);
            }
        }
    }
}
