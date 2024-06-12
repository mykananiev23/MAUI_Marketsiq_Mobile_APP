using MarketsIQ.ViewModels.Maket;

namespace MarketsIQ.Views.Market;

public partial class ForexPage : ContentPage
{
	public ForexPage()
	{
		InitializeComponent();

		BindingContext = new ForexViewModel();
	}
}