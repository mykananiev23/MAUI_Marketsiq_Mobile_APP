using MarketsIQ.Services.Quantower.API.Client.Models.Quotes;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QEventArgs : EventArgs
    {
        public QMarketQuote MarketData { get; set; }
    }
}
