using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QInstrument
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("localId")]
        public string LocalId { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("type")]
        public QInstrumentType Type { get; private set; }

        [JsonProperty("state")]
        public QInstrumentState State { get; private set; }

        [JsonProperty("exchangeId")]
        public int ExchangeId { get; private set; }

        [JsonProperty("defaultHistoryType")]
        public QHistoryType DefaultHistoryType { get; private set; }

        [JsonProperty("baseAsset")]
        public QAsset BaseAsset { get; private set; }

        [JsonProperty("quoteAsset")]
        public QAsset QuoteAsset { get; private set; }

        [JsonProperty("tickSize")]
        public double TickSize { get; private set; }

        [JsonProperty("deltaCalculationType")]
        public QDeltaCalculationType DeltaCalculationType { get; set; }

        [JsonProperty("futuresInfo")]
        public QFuturesDerivativeInfo FuturesInfo { get; set; }

        [JsonProperty("optionInfo")]
        public QOptionDerivativeInfo OptionInfo { get; set; }

        [JsonProperty("sessionsContainerId")]
        public int? SessionsContainerId { get; set; }

        [JsonProperty("feedName")]
        public string FeedName { get; set; }
    }
}
