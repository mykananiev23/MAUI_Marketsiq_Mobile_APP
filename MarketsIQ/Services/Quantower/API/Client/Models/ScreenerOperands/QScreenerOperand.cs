using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerOperand
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("parameters", ItemConverterType = typeof(QScreenerParameterConverter))]
        public QScreenerParameter[] Parameters { get; set; }

        [JsonProperty("type")]
        public QScreenerOperandType OperandType { get; set; }

        [JsonProperty("valueType")]
        public QScreenerOperandValueType ValueType { get; set; }
    }
}
