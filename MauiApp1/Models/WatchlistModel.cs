using MauiApp1.Models.Market;
using System.Diagnostics.Metrics;

namespace MauiApp1.Models
{
    public class WatchlistModel
    {
        private List<Instrument> _instrumentsInfo;

        public string Title { get; set; }

        public List<BaseSymbolModel> Symbols { get; set; }
    }
}
