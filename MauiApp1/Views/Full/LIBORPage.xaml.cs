using MarketsIQ.ViewModels.Full;

namespace MarketsIQ.Views.Full;

public partial class LIBORPage : ContentPage
{
	public LIBORPage()
	{
		InitializeComponent();

		BindingContext = new LiborViewModel();

    }
}