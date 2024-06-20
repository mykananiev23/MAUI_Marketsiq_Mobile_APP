using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QAsset
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("precision")]
        public int Precision { get; private set; }
    }
}
