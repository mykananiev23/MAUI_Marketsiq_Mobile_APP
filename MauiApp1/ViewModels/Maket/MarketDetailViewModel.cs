using MauiApp1.Models.Market;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels.Maket
{
    class MarketDetailViewModel : IQueryAttributable, INotifyPropertyChanged
    {
        public ListMainModel SymbolInfo { get; set; }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            SymbolInfo = query["SymbolInfo"] as ListMainModel;
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