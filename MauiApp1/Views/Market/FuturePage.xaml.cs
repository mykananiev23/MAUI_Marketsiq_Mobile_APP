using MarketsIQ.ViewModels.Maket;

namespace MarketsIQ.Views.Market;

public partial class FuturePage : ContentPage
{
	public FuturePage()
	{
		InitializeComponent();

		BindingContext = new FutureViewModel();
	}
}