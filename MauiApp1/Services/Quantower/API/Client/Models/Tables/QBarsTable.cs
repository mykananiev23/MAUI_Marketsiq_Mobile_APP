using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Tables
{
    public class QBarsTable : QMarketDataTable
    {
        [JsonProperty("openPrice")]
        public double[] OpenPriceArray { get; internal set; }

        [JsonProperty("highPrice")]
        public double[] HighPriceArray { get; internal set; }

        [JsonProperty("lowPrice")]
        public double[] LowPriceArray { get; internal set; }

        [JsonProperty("closePrice")]
        public double[] ClosePriceArray { get; internal set; }

        [JsonProperty("volume")]
        public double[] VolumeArray { get; internal set; }

        [JsonProperty("ticks")]
        public long[] TicksArray { get; internal set; }

        [JsonProperty("openInterest")]
        public double[] OpenInterest { get; internal set; }
    }
}
