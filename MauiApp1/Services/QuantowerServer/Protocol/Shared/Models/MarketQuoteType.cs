using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum MarketQuoteType
    {
        [OriginalName("LEVEL1")]
        Level1,
        [OriginalName("LEVEL2")]
        Level2,
        [OriginalName("TRADE")]
        Trade,
        [OriginalName("DOM")]
        Dom,
        [OriginalName("DAY_BAR")]
        DayBar
    }
}
