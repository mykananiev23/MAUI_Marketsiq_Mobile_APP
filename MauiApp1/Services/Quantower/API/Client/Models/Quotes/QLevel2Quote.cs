using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Quotes
{
    public class QLevel2Quote : QMarketQuote
    {
        public override QMarketQuoteType Type => QMarketQuoteType.Level2;

        public string Mmid { get; }

        public QLevel2Type Level2Type { get; }

        public bool IsClosed { get; }

        public double Price { get; }

        public double Size { get; }

        internal QLevel2Quote(MarketQuoteMessage message)
            : this(message.InstrumentId, message.Time, message.Level2)
        {
        }

        internal QLevel2Quote(int instrumentId, long timeTicks, Level2QuoteMessage leve2Message)
            : base(instrumentId, timeTicks)
        {
            if (leve2Message != null)
            {
                Mmid = leve2Message.Mmid;
                Level2Type = ((leve2Message.Type != 0) ? QLevel2Type.Ask : QLevel2Type.Bid);
                IsClosed = leve2Message.IsClosed;
                Price = leve2Message.Price;
                Size = leve2Message.Size;
            }
        }
    }
}
