using System.Diagnostics.Tracing;
using System.Net.Sockets;
using MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.Sockets
{
    public class AsyncSocketNetworkConnector<TPacketSeparator> : SocketNetworkConnector<TPacketSeparator> where TPacketSeparator : IPacketSeparator, new()
    {
        private readonly ManualResetEvent connectionAcceptEvent;

        public AsyncSocketNetworkConnector(int maxConnectionsCount, Action<EventLevel, string, Exception> logCallback = null)
            : base(maxConnectionsCount, logCallback)
        {
            connectionAcceptEvent = new ManualResetEvent(initialState: false);
        }

        protected override ISocketStream CreateStream(int index)
        {
            return new AsyncSocketStream<TPacketSeparator>(LogCallback)
            {
                Id = index
            };
        }

        protected override void AcceptConnection()
        {
            connectionAcceptEvent.Reset();
            ListenerSocket.BeginAccept(ConnectionAccepted, null);
            connectionAcceptEvent.WaitOne();
        }

        private void ConnectionAccepted(IAsyncResult asyncResult)
        {
            int index;
            ISocketStream stream = FindAvailableStream(out index);
            connectionAcceptEvent.Set();
            try
            {
                Socket clientSocket = ListenerSocket.EndAccept(asyncResult);
                BindStreamWithSocket(stream, clientSocket, index);
            }
            catch (Exception arg)
            {
                LogCallback?.Invoke(EventLevel.Warning, "ConnectionAccepted", arg);
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            connectionAcceptEvent.Set();
        }
    }
}
