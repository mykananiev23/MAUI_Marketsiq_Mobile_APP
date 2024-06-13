using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum SessionState
    {
        [OriginalName("UNDEFINED")]
        Undefined,
        [OriginalName("OPENED")]
        Opened,
        [OriginalName("CLOSED")]
        Closed
    }
}
