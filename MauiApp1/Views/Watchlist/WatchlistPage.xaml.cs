using MauiApp1.Models.Market;
using MauiApp1.Services;
using MauiApp1.ViewModels;

namespace MauiApp1.Views.Watchlist;

public partial class WatchlistPage : ContentPage
{
	public WatchlistPage(MarketsIQService connectionService)
	{
		InitializeComponent();

		BindingContext=new WatchlistViewModel();
	}

	private async void OnHandlerChangeWatchlist(object sender, SelectionChangedEventArgs e)
	{
		string selectedTitle = e.CurrentSelection.FirstOrDefault() as string;

    }

	private async void OnHandleMoveDetailPage(object sender, SelectionChangedEventArgs e)
	{
        BaseSymbolModel symbolfeed = e.CurrentSelection.FirstOrDefault() as BaseSymbolModel;

        var navigationParameters = new Dictionary<string, object>
        {
            {"SymbolInfo", symbolfeed }
        };

        await Shell.Current.GoToAsync($"MarketDetail", navigationParameters);
    }

    private void ScrollView_Loaded(object sender, EventArgs e)
    {

    }
}