namespace MarketsIQ.Models.Watchlist
{
    public class MainModel
    {
        public string Title { get; set; }
        public IList<WatchlistDataModel> Symbols { get; set; }
    }
}
