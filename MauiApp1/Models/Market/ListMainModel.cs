using Quantower.API.Client.Models;
using Quantower.API.Client.Models.Quotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models.Market
{
    public class ListMainModel : INotifyPropertyChanged
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
