using MarketsIQ.ViewModels.Maket;

namespace MauiApp1.Views.Market;

public partial class CommodityPage : ContentPage
{
	public CommodityPage()
	{
		InitializeComponent();

		BindingContext = new CommodityViewModel();

    }
}