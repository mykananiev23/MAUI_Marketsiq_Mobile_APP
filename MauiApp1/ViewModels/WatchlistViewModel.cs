using MarketsIQ.Data;
using MarketsIQ.Models.Watchlist;
using MarketsIQ.Services;
using MarketsIQ.Services.Quantower.API.Client.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarketsIQ.ViewModels
{
    class WatchlistViewModel: INotifyPropertyChanged
    {
        private MainModel _selectedItem;
        public List<QInstrument> InstrumentsList { get; set; }
        public IList<MainModel> Watchlists { get; set; }

        public MainModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public WatchlistViewModel()
        {
            Watchlists = WatchlistData.Watchlists;

            SelectedItem = Watchlists.FirstOrDefault();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
#region Old Script
//using MarketsIQ.Models;
//using MarketsIQ.Models.Market;
//using MarketsIQ.Services;
//using Quantower.API.Client;
//using Quantower.API.Client.Models;
//using Quantower.API.Client.Models.Quotes;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;

//namespace MarketsIQ.ViewModels
//{
//    class WatchlistViewModel: INotifyPropertyChanged
//    {
//        #region declaration
//        public List<WatchlistModel> Watchlists { get; set; } = new List<WatchlistModel>();
//        public WatchlistModel SelectedItem { get; set; }
//        private List<QInstrument> CellInstruments { get; set; }
//        private List<QInstrument> _Instruments { get; set; }
//        private List<QInstrument> _TestInstruments { get; set; }
//        private QApiClient _apiClient { get; set; }
//        #endregion

//        #region initialization
//        public WatchlistViewModel(MarketsIQService connectionService)
//        {
//            _Instruments = connectionService.GetInstruments().ToList();
//            _TestInstruments = _Instruments.Take(2).ToList();
//            _apiClient = connectionService.GetApiClient();

//            Watchlists.Add(new WatchlistModel { Title = "Watchlist1" });
//            Watchlists.Add(new WatchlistModel { Title = "Watchlist2" });
//            Watchlists.Add(new WatchlistModel { Title = "Watchlist3" });

//            foreach (var watchlist in Watchlists)
//            {
//                watchlist.Symbols = new List<BaseSymbolModel>();
//                foreach (var symbol in _TestInstruments)
//                {
//                    watchlist.Symbols.Add(new BaseSymbolModel { InstrumentId = symbol.Id, Instrument = symbol, TradeQuote = null });
//                }
//                foreach (var symbol in watchlist.Symbols)
//                {
//                    _apiClient.Quotes.Subscribe(symbol.InstrumentId, QMarketQuoteType.Trade);
//                }
//            }

//            _apiClient.Quotes.MarketQuoteReceived += this._SubscribeByInstrument;
//            SelectedItem = Watchlists.FirstOrDefault();
//        }
//        #endregion

//        #region private methods
//        private void _SubscribeByInstrument(object sender, QEventArgs e)
//        {
//            if (e.MarketData is QTradeQuote qTrade)
//            {
//                Watchlists.ForEach(watchlist =>
//                {
//                    watchlist.Symbols
//                        .Where(symbol => symbol.InstrumentId == qTrade.InstrumentId)
//                        .ToList()
//                        .ForEach(symbol => symbol.TradeQuote = qTrade);
//                });
//            }
//        }
//        #endregion

//        #region IPropertyChanged
//        public event PropertyChangedEventHandler PropertyChanged;

//        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        {
//            PropertyChangedEventHandler handler = PropertyChanged;
//            if (handler != null)
//            {
//                handler(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }
//        #endregion
//    }
//}
#endregion