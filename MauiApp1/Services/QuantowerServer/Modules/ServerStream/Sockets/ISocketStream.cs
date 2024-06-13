using System.Net.Sockets;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.Sockets
{
    public interface ISocketStream : IStream
    {
        Socket Socket { get; set; }
    }
}
