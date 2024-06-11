using MauiApp1.ViewModels.Full;

namespace MauiApp1.Views.Full;

public partial class FxSpotPage : ContentPage
{
	public FxSpotPage()
	{
		InitializeComponent();

		BindingContext = new SpotViewModel();
	}
}