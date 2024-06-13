using MarketsIQ.Models.Market;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarketsIQ.ViewModels.Maket
{

    class MarketDetailViewModel: IQueryAttributable, INotifyPropertyChanged
    {
        public BaseSymbolModel SymbolInfo { get; set; }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            SymbolInfo = query["SymbolInfo"] as BaseSymbolModel;

            OnPropertyChanged("SymbolInfo");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

