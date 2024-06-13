using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Quotes
{
    public abstract class QMarketQuote
    {
        public abstract QMarketQuoteType Type { get; }

        public int InstrumentId { get; }

        public DateTime Time { get; }

        protected QMarketQuote(int instrumentId, long timeTicks)
        {
            InstrumentId = instrumentId;
            Time = new DateTime(timeTicks, DateTimeKind.Utc);
        }

        protected QMarketQuote(MarketQuoteMessage message)
            : this(message.InstrumentId, message.Time)
        {
        }

        public static QMarketQuote CreateFrom(MarketQuoteMessage message)
        {
            return message.Type switch
            {
                MarketQuoteType.Level1 => new QLevel1Quote(message),
                MarketQuoteType.Level2 => new QLevel2Quote(message),
                MarketQuoteType.Trade => new QTradeQuote(message),
                MarketQuoteType.Dom => new QDomQuote(message),
                MarketQuoteType.DayBar => new QDayBarQuote(message),
                _ => throw new ArgumentOutOfRangeException(message.Type.ToString()),
            };
        }
    }
}
