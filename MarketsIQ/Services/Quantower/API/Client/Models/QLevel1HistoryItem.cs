namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QLevel1HistoryItem
    {
        public long Time { get; internal set; }

        public double BidPrice { get; internal set; }

        public double AskPrice { get; internal set; }

        public double BidSize { get; internal set; }

        public double AskSize { get; internal set; }
    }
}
