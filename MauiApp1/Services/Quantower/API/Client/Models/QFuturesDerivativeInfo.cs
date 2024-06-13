using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QFuturesDerivativeInfo
    {
        [JsonProperty("underlierId")]
        public int? UnderlierId { get; set; }

        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("spotId")]
        public int? SpotId { get; set; }

        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }
    }
}
