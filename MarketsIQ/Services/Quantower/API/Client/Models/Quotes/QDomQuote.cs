using System.Collections.Generic;
using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Models.Quotes
{
    public class QDomQuote : QMarketQuote
    {
        public override QMarketQuoteType Type => QMarketQuoteType.Dom;

        public QLevel2Quote[] Bids { get; }

        public QLevel2Quote[] Asks { get; }

        internal QDomQuote(MarketQuoteMessage message)
            : base(message)
        {
            DomQuoteMessage dom = message.Dom;
            if (dom == null)
            {
                return;
            }

            List<QLevel2Quote> list = new List<QLevel2Quote>();
            List<QLevel2Quote> list2 = new List<QLevel2Quote>();
            foreach (Level2QuoteMessage bid in dom.Bids)
            {
                list.Add(new QLevel2Quote(message.InstrumentId, message.Time, bid));
            }

            foreach (Level2QuoteMessage ask in dom.Asks)
            {
                list2.Add(new QLevel2Quote(message.InstrumentId, message.Time, ask));
            }

            Bids = list.ToArray();
            Asks = list2.ToArray();
        }
    }
}
