using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Models.Watchlist
{
    public class MainModel
    {
        public string Title { get; set; }
        public IList<WatchlistDataModel> Symbols { get; set; }
    }
}
