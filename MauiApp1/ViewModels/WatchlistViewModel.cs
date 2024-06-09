using MauiApp1.Models.Market;
using MauiApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    class WatchlistViewModel
    {
        public List<ListMainModel> WatchlistLists { get; set; }

        public WatchlistViewModel ( MarketsIQService connectService )
        {
            var instruments = connectService.GetInstruments();


        }
    }
}
