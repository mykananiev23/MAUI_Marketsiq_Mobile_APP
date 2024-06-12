using MarketsIQ.Models.Market;
using System.Diagnostics.Metrics;

namespace MarketsIQ.Models
{
    public class WatchlistModel
    {
        public string Title { get; set; }

        public List<BaseSymbolModel> Symbols { get; set; }
    }
}
