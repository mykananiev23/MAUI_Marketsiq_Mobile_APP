using Newtonsoft.Json;
using MarketsIQ.Services.Quantower.API.Client.Business.JsonConverters;

namespace MarketsIQ.Services.Quantower.API.Client.Models.VolumeAnalysis
{
    [JsonConverter(typeof(QVolumeAnalysisItemJsonConverter))]
    public class QVolumeAnalysisItem
    {
        public double Volume { get; internal set; }

        public double BuyVolume { get; internal set; }

        public double SellVolume { get; internal set; }

        public double MaxOneTradeVolume { get; internal set; }

        public int Trades { get; internal set; }

        public int BuyTrades { get; internal set; }

        public int SellTrades { get; internal set; }
    }
}
