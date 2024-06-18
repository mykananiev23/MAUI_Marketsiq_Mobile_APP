using MarketsIQ.Services.Quantower.API.Client.Models;

namespace MarketsIQ.Models.Watchlist
{
    public class MainModel
    {
        public string Title { get; set; }
        public IList<QInstrument> Symbols { get; set; }
    }
}
