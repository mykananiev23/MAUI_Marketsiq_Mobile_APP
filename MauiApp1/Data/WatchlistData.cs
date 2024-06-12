using MarketsIQ.Models.Watchlist;

namespace MarketsIQ.Data
{
    public class WatchlistData
    {
        public static IList<MainModel> Watchlists { get; set; } = new List<MainModel>();

        public static IList<WatchlistDataModel> Symbols1 { get; set; } = new List<WatchlistDataModel>();
        public static IList<WatchlistDataModel> Symbols2 { get; set; } = new List<WatchlistDataModel>();
        public static IList<WatchlistDataModel> Symbols3 { get; set; } = new List<WatchlistDataModel>();

        static WatchlistData()
        {
            #region Watchlist1 symbols
            Symbols1.Add(new WatchlistDataModel
            {
                Description = "Symbol11",
                AskPrice = "1.00",
                BidPrice = "1.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "1.00",
                BidVolumn = "1.00"
            });

            Symbols1.Add(new WatchlistDataModel
            {
                Description = "Symbol12",
                AskPrice = "1.00",
                BidPrice = "1.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "1.00",
                BidVolumn = "1.00"
            });

            Symbols1.Add(new WatchlistDataModel
            {
                Description = "Symbol13",
                AskPrice = "1.00",
                BidPrice = "1.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "1.00",
                BidVolumn = "1.00"
            });
            #endregion

            #region Watchlist2 Symbols
            Symbols2.Add(new WatchlistDataModel
            {
                Description = "Symbol21",
                AskPrice = "2.00",
                BidPrice = "2.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "2.00",
                BidVolumn = "2.00"
            });

            Symbols2.Add(new WatchlistDataModel
            {
                Description = "Symbol22",
                AskPrice = "2.00",
                BidPrice = "2.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "2.00",
                BidVolumn = "2.00"
            });
            #endregion

            #region Watchlist3 Symbols
            Symbols3.Add(new WatchlistDataModel
            {
                Description = "Symbol31",
                AskPrice = "3.00",
                BidPrice = "3.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "3.00",
                BidVolumn = "3.00"
            });

            Symbols3.Add(new WatchlistDataModel
            {
                Description = "Symbol31",
                AskPrice = "3.00",
                BidPrice = "3.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "3.00",
                BidVolumn = "3.00"
            });

            Symbols3.Add(new WatchlistDataModel
            {
                Description = "Symbol31",
                AskPrice = "3.00",
                BidPrice = "3.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "3.00",
                BidVolumn = "3.00"
            });

            Symbols3.Add(new WatchlistDataModel
            {
                Description = "Symbol31",
                AskPrice = "3.00",
                BidPrice = "3.00",
                Time = "12:12:12",
                Type = "Index",
                AskVolumn = "3.00",
                BidVolumn = "3.00"
            });
            #endregion

            Watchlists.Add(new MainModel
            {
                Title = "Watchlist1",
                Symbols = Symbols1
            });

            Watchlists.Add(new MainModel
            {
                Title = "Watchlist2",
                Symbols = Symbols2
            });

            Watchlists.Add(new MainModel
            {
                Title = "Watchlist3",
                Symbols = Symbols3
            });
        }
    }
}
