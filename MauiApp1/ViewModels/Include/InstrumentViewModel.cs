using MarketsIQ.Services.Quantower.API.Client.Models;
using System.ComponentModel;

namespace MarketsIQ.ViewModels.Include
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
