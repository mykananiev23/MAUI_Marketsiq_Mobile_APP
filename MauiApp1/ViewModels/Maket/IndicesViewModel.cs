using MauiApp1.Services;
using Quantower.API.Client;
using Quantower.API.Client.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MauiApp1.ViewModels.Include;
using Android.Telecom;

namespace MauiApp1.ViewModels.Maket
{
    class IndicesViewModel
    {
        public QInstrument[] Symbols {  get; set; }

        public IndicesViewModel(MarketsIQService connectService)
        {
            Symbols = connectService.GetInstruments().Take(4).ToArray();
        }
    }
}
