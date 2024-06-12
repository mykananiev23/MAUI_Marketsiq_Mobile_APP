using MarketsIQ.Models.Market;
using MarketsIQ.Services;
using MarketsIQ.ViewModels.Maket;

namespace MarketsIQ.Views.Market;

public partial class IndicesPage : ContentPage
{
	public IndicesPage(MarketsIQService connectService)
	{
		InitializeComponent();

		BindingContext = new IndicesViewModel(connectService);
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
}