using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.QuantowerServer.Protocol.Client.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Sockets
{
    public class QSocketEventArgs : EventArgs
    {
        public ServerMessage ServerMessage { get; internal set; }

        public QClientConnectionState ConnectionState { get; internal set; }
    }
}
