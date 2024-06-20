using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Tables
{
    public abstract class QMarketDataTable
    {
        [JsonProperty("time")]
        public DateTime[] TimeArray { get; internal set; }

        [JsonProperty("length")]
        public int Length { get; internal set; }
    }
}
