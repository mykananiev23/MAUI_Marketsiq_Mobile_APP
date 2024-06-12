using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Models.Watchlist
{
    public class WatchlistDataModel
    {
        public string Description { get; set; }
        public string BidPrice { get; set; }
        public string AskPrice { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string BidVolumn { get; set; }
        public string AskVolumn { get; set; }
    }
}
