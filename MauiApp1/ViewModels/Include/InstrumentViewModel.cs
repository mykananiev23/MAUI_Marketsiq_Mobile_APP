using Quantower.API.Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels.Include
{
    public class InstrumentViewModel : INotifyPropertyChanged
    {
        public QInstrument Instrument { get; private set; }

        private double currentPrice;
        public double CurrentPrice
        {
            get => currentPrice;
            set
            {
                if (currentPrice != value)
                {
                    currentPrice = value;
                    OnPropertyChanged(nameof(CurrentPrice));
                }
            }
        }

        public InstrumentViewModel(QInstrument instrument)
        {
            Instrument = instrument;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
