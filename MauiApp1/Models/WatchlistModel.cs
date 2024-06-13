using MarketsIQ.Models.Market;

namespace MarketsIQ.Models
{
    public class WatchlistModel
    {
        public string Title { get; set; }

        public List<BaseSymbolModel> Symbols { get; set; }
    }
}
