using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum MarketDataRequestType
    {
        [OriginalName("SUBSCRIBE")]
        Subscribe,
        [OriginalName("UNSUBSCRIBE")]
        Unsubscribe
    }
}
