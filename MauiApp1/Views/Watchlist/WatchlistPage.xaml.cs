using MarketsIQ.Models.Market;
using MarketsIQ.Services;
using MarketsIQ.ViewModels;

namespace MarketsIQ.Views.Watchlist;

public partial class WatchlistPage : ContentPage
{
	public WatchlistPage(MarketsIQService connectionService)
	{
		InitializeComponent();

		BindingContext=new WatchlistViewModel();
	}

	private void OnHandlerChangeWatchlist(object sender, SelectionChangedEventArgs e)
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