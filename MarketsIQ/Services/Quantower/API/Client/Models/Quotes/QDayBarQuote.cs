using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Quotes
{
    public class QDayBarQuote : QMarketQuote
    {
        public override QMarketQuoteType Type => QMarketQuoteType.DayBar;

        public double BidPrice { get; }

        public double BidSize { get; }

        public double AskPrice { get; }

        public double AskSize { get; }

        public double TradePrice { get; }

        public double TradeSize { get; }

        public double OpenInterest { get; }

        public double Open { get; }

        public double High { get; }

        public double Low { get; }

        public double PrevClose { get; }

        public double Volume { get; }

        public long Ticks { get; }

        public long Trades { get; }

        public DateTime ExpirationDate { get; }

        internal QDayBarQuote(MarketQuoteMessage message)
            : base(message)
        {
            DayBarQuoteMessage dayBar = message.DayBar;
            if (dayBar != null)
            {
                BidPrice = dayBar.BidPrice;
                BidSize = dayBar.BidSize;
                AskPrice = dayBar.AskPrice;
                AskSize = dayBar.AskSize;
                TradePrice = dayBar.TradePrice;
                TradeSize = dayBar.TradeSize;
                OpenInterest = dayBar.OpenInterest;
                Open = dayBar.Open;
                High = dayBar.High;
                Low = dayBar.Low;
                PrevClose = dayBar.PrevClose;
                Volume = dayBar.Volume;
                Ticks = dayBar.Ticks;
                Trades = dayBar.Trades;
                ExpirationDate = new DateTime(dayBar.ExpirationDateTicks, DateTimeKind.Utc);
            }
        }
    }
}
