using MarketsIQ.ViewModels.Maket;

namespace MauiApp1.Views.Market;

public partial class FuturePage : ContentPage
{
	public FuturePage()
	{
		InitializeComponent();

		BindingContext = new FutureViewModel();
	}
}