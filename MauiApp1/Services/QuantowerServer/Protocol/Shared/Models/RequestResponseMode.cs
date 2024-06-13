using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum RequestResponseMode
    {
        [OriginalName("REQUEST")]
        Request,
        [OriginalName("RESPONSE")]
        Response,
        [OriginalName("DIRECT")]
        Direct
    }
}
