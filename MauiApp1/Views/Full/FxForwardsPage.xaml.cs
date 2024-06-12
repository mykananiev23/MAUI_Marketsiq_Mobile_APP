using MarketsIQ.ViewModels.Full;

namespace MarketsIQ.Views.Full;

public partial class FxForwardsPage : ContentPage
{
	public FxForwardsPage()
	{
		InitializeComponent();

		BindingContext = new FowardViewModel();

    }
}