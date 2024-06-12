using MarketsIQ.ViewModels.Full;

namespace MarketsIQ.Views.Full;

public partial class FxSpotPage : ContentPage
{
	public FxSpotPage()
	{
		InitializeComponent();

		BindingContext = new SpotViewModel();
	}
}