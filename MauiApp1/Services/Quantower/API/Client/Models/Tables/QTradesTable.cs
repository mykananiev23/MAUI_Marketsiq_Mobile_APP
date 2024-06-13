using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Tables
{
    public class QTradesTable : QMarketDataTable
    {
        [JsonProperty("tradePrice")]
        public double[] PriceArray { get; internal set; }

        [JsonProperty("tradeSize")]
        public double[] SizeArray { get; internal set; }

        [JsonProperty("openInterest")]
        public double[] OpenInterestArray { get; internal set; }

        [JsonProperty("aggressorFlag")]
        public QAggressorFlag[] AggressorFlagArray { get; internal set; }
    }
}
