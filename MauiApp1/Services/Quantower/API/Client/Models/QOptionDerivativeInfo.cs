using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QOptionDerivativeInfo
    {
        [JsonProperty("underlierId")]
        public int UnderlierId { get; set; }

        [JsonProperty("strikePrice")]
        public double StrikePrice { get; set; }

        [JsonProperty("strikeMultiplier")]
        public double StrikeMultiplier { get; set; }

        [JsonProperty("optionType")]
        public QOptionType OptionType { get; set; }

        [JsonProperty("expirationDate")]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("seriesName")]
        public string SeriesName { get; set; }
    }
}
