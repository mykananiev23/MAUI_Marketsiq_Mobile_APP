using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Quotes
{
    public class QLevel1Quote : QMarketQuote
    {
        public override QMarketQuoteType Type => QMarketQuoteType.Level1;

        public double BidPrice { get; }

        public double BidSize { get; }

        public double AskPrice { get; }

        public double AskSize { get; }

        internal QLevel1Quote(MarketQuoteMessage message)
            : base(message)
        {
            Level1QuoteMessage level = message.Level1;
            if (level != null)
            {
                BidPrice = level.BidPrice;
                BidSize = level.BidSize;
                AskPrice = level.AskPrice;
                AskSize = level.AskSize;
            }
        }
    }
}
