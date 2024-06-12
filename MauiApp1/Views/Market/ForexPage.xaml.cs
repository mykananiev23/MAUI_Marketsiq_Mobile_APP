using MarketsIQ.ViewModels.Maket;

namespace MauiApp1.Views.Market;

public partial class ForexPage : ContentPage
{
	public ForexPage()
	{
		InitializeComponent();

		BindingContext = new ForexViewModel();
	}
}