using MauiApp1.ViewModels.Maket;

namespace MauiApp1.Views.Market;

public partial class MarketDetail : ContentPage
{
	public MarketDetail()
	{
		InitializeComponent();

        BindingContext = new MarketDetailViewModel();
    }
}