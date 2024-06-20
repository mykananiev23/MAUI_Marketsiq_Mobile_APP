using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Quotes
{
    public class QTradeQuote : QMarketQuote
    {
        public override QMarketQuoteType Type => QMarketQuoteType.Trade;

        public double Price { get; }

        public double Size { get; }

        public double OpenInterest { get; }

        public QAggressorFlag AggressorFlag { get; }

        internal QTradeQuote(MarketQuoteMessage message)
            : base(message)
        {
            TradeQuoteMessage trade = message.Trade;
            if (trade != null)
            {
                Price = trade.Price;
                Size = trade.Size;
                OpenInterest = trade.OpenInterest;
                AggressorFlag = Convert(trade.AggressorFlag);
            }
        }

        private static QAggressorFlag Convert(AggressorFlag aggressorFlag)
        {
            return aggressorFlag switch
            {
                QuantowerServer.Protocol.Shared.Models.AggressorFlag.Buy => QAggressorFlag.Buy,
                QuantowerServer.Protocol.Shared.Models.AggressorFlag.Sell => QAggressorFlag.Sell,
                QuantowerServer.Protocol.Shared.Models.AggressorFlag.None => QAggressorFlag.None,
                _ => QAggressorFlag.NotSet,
            };
        }
    }
}
