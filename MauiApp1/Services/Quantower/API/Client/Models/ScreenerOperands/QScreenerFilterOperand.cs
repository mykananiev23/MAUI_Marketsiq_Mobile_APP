using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerFilterOperand
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parameters")]
        public IDictionary<string, object> Parameters { get; set; }

        [JsonIgnore]
        public bool WithFixedValue { get; set; }
    }
}
