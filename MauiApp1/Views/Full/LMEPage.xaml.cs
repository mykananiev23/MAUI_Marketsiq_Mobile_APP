using MauiApp1.ViewModels.Full;

namespace MauiApp1.Views.Full;

public partial class LMEPage : ContentPage
{
	public LMEPage()
	{
		InitializeComponent();

		BindingContext = new LMEViewModel();
	}
}