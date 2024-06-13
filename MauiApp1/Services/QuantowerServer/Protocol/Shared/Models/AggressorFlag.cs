using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum AggressorFlag
    {
        [OriginalName("BUY")]
        Buy,
        [OriginalName("SELL")]
        Sell,
        [OriginalName("NONE")]
        None,
        [OriginalName("NOT_SET")]
        NotSet
    }
}
