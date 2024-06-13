using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Tables
{
    public class QLevel1Table : QMarketDataTable
    {
        [JsonProperty("bidPrice")]
        public double[] BidPriceArray { get; internal set; }

        [JsonProperty("bidSize")]
        public double[] BidSizeArray { get; internal set; }

        [JsonProperty("askPrice")]
        public double[] AskPriceArray { get; internal set; }

        [JsonProperty("askSize")]
        public double[] AskSizeArray { get; internal set; }
    }
}
