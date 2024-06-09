using Quantower.API.Client.Models;

namespace MauiApp1.Models.Market
{
    public class WatchilistModel
    {
        public string WatchlistTitle { get; set; }
        
        public QInstrument[] Symbols { get; set; }
    }
}
