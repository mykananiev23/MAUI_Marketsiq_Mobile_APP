using MauiApp1.ViewModels.Full;

namespace MauiApp1.Views.Full;

public partial class FxForwardsPage : ContentPage
{
	public FxForwardsPage()
	{
		InitializeComponent();

		BindingContext = new FowardViewModel();

    }
}