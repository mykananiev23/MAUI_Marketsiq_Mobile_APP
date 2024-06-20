using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QScreenerParameterType
    {
        Number,
        Selector,
        Period,
        Boolean
    }
}
