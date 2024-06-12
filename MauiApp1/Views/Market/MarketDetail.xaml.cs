using MarketsIQ.ViewModels.Maket;

namespace MarketsIQ.Views.Market;

public partial class MarketDetail : ContentPage
{
	public MarketDetail()
	{
		InitializeComponent();

		BindingContext = new MarketDetailViewModel();
	}
}