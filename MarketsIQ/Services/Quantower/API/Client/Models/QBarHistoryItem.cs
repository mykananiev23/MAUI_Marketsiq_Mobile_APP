namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QBarHistoryItem
    {
        public DateTime Time { get; internal set; }

        public double Open { get; internal set; }

        public double Close { get; internal set; }

        public double Low { get; internal set; }

        public double High { get; internal set; }

        public double Volume { get; internal set; }

        public long Ticks { get; internal set; }

        public double OpenInterest { get; internal set; }
    }
}
