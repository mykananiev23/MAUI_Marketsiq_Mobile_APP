using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum Level2Type
    {
        [OriginalName("BID")]
        Bid,
        [OriginalName("ASK")]
        Ask
    }
}
