using MauiApp1.Models.Market;
using MauiApp1.Services;
using Quantower.API.Client;
using Quantower.API.Client.Models;
using Quantower.API.Client.Models.Quotes;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels.Maket
{
    class IndicesViewModel
    {
        private QInstrument[] Symbols {  get; set; }
        private QApiClient _client;

        public ObservableCollection<BaseSymbolModel> Lists { get; set; } = new ObservableCollection<BaseSymbolModel>();

        public IndicesViewModel(MarketsIQService connectService)
        {
            _client = connectService.GetApiClient();
            Symbols = connectService.GetInstruments().Take(2).ToArray();
            foreach (QInstrument instrument in Symbols)
            {
                Lists.Add(new BaseSymbolModel
                {
                    InstrumentId = instrument.Id,
                    Instrument = instrument,
                    TradeQuote = null
                });
                _client.Quotes.Subscribe(instrument.Id, QMarketQuoteType.Trade);
            }

            _client.Quotes.MarketQuoteReceived += this.CellSubscribe;
        }

        public void CellSubscribe(object sender, QEventArgs e)
        {
            if (e.MarketData is QTradeQuote qTrade)
            {
                var list = Lists.FirstOrDefault(l => l.InstrumentId == qTrade.InstrumentId);
                if (list != null)
                {
                    list.TradeQuote = qTrade;
                }
            }
        }
    }
}
