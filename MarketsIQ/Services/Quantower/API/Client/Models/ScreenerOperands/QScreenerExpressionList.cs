using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerExpressionList
    {
        [JsonProperty("items", ItemConverterType = typeof(QScreenerExpressionConverter))]
        public QScreenerExpression[] Expressions { get; set; }
    }
}
