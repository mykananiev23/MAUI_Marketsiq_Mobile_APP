using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerSelectorParameter : QScreenerParameter<string>
    {
        [JsonProperty("variants")]
        public QScreenerSelectorItem[] Variants { get; set; }
    }
}
