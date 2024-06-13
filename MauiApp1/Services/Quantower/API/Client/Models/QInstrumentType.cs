using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QInstrumentType
    {
        Undefined,
        Forex,
        Futures,
        Equity,
        Cfd,
        Bond,
        Crypto,
        Index,
        Spot,
        Forward,
        Option,
        ETF
    }
}
