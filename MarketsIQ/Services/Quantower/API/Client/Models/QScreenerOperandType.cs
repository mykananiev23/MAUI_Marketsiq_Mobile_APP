using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QScreenerOperandType
    {
        Unary,
        Binary
    }
}
