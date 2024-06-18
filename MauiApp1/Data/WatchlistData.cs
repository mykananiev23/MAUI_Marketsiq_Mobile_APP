using MarketsIQ.Models.Watchlist;
using MarketsIQ.Services;
using MarketsIQ.Services.Quantower.API.Client.Models;
using System.Diagnostics.Metrics;

namespace MarketsIQ.Data
{
    public class WatchlistData
    {
        public static IList<MainModel> Watchlists { get; set; } = new List<MainModel>();

        static WatchlistData()
        {
            #region Watchlist symbols
            var IndexSymbols = MarketsIQService.Instruments.Where(instrument => instrument.Type == QInstrumentType.Index)
                .Select(instrument => instrument).Take(4).ToList();

            var Furture = MarketsIQService.Instruments.Where(instrument => instrument.Type == QInstrumentType.Futures)
                .Select(instrument => instrument).Take(3).ToList();

            var ForexSymbols = MarketsIQService.Instruments.Where(instrument => instrument.Type == QInstrumentType.Forex)
                .Select(instrument => instrument).Take(5).ToList();

            #endregion

            Watchlists.Add(new MainModel
            {
                Title = "Watchlist1",
                Symbols = IndexSymbols
            });

            Watchlists.Add(new MainModel
            {
                Title = "Watchlist2",
                Symbols = Furture
            });

            Watchlists.Add(new MainModel
            {
                Title = "Watchlist3",
                Symbols = ForexSymbols
            });
        }
    }
}
