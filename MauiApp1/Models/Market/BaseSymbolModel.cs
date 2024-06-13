using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.Quantower.API.Client.Models.Quotes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarketsIQ.Models.Market
{
    public class BaseSymbolModel : INotifyPropertyChanged
    {
        private QInstrument instrument;
        private QTradeQuote tradeQuote;

        public int InstrumentId { get; set; }

        public QInstrument Instrument
        {
            get => instrument;
            set
            {
                instrument = value;
                OnPropertyChanged();
            }
        }

        public QTradeQuote TradeQuote
        {
            get => tradeQuote;
            set
            {
                tradeQuote = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
