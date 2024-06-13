using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QInstrumentState
    {
        Active = 0,
        Expired = 10,
        Delisted = 20
    }
}
