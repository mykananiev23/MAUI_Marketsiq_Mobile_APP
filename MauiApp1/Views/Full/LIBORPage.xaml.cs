using MauiApp1.ViewModels.Full;

namespace MauiApp1.Views.Full;

public partial class LIBORPage : ContentPage
{
	public LIBORPage()
	{
		InitializeComponent();

		BindingContext = new LiborViewModel();

    }
}