using MarketsIQ.ViewModels.Maket;

namespace MarketsIQ.Views.Market;

public partial class CommodityPage : ContentPage
{
	public CommodityPage()
	{
		InitializeComponent();

		BindingContext = new CommodityViewModel();

    }
}