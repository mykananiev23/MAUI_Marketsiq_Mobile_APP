using MauiApp1.Models.Market;
using System.Diagnostics.Metrics;

namespace MauiApp1.Models
{
    public class WatchlistModel
    {
        private List<Instrument> _instrumentsInfo;

        public string Title { get; set; }

        public List<BaseSymbolModel> Symbols { get; set; }

        //public List<Instrument> InstrumentsInfo
        //{
        //    get => _instrumentsInfo;
        //    set => _instrumentsInfo = value ?? new List<Instrument>(); // Ensure non-null value
        //}

        //public WatchlistModel()
        //{
        //    _instrumentsInfo = new List<Instrument>();
        //}
    }
}
