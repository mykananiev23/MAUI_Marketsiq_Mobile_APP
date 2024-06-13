using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.VolumeAnalysis
{
    public class QVolumeAnalysisData
    {
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        [JsonProperty("total")]
        public QVolumeAnalysisItem Total { get; private set; }

        [JsonProperty("priceLevels")]
        public Dictionary<double, QVolumeAnalysisItem> PriceLevels { get; private set; }
    }
}
