using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerExpressionRequest
    {
        [JsonProperty("itemGroups")]
        public QScreenerExpressionList[] ExpressionList { get; set; }

        [JsonProperty("instrumentsFilter")]
        public object InstrumentFilter { get; set; } = new object();

    }
}
