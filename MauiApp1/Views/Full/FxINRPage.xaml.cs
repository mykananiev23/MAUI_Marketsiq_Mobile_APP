using MauiApp1.ViewModels.Full;

namespace MauiApp1.Views.Full;

public partial class FxINRPage : ContentPage
{
	public FxINRPage()
	{
		InitializeComponent();

		BindingContext = new INRViewModel();
	}
}