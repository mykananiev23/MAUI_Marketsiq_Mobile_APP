using MarketsIQ.ViewModels.Full;

namespace MarketsIQ.Views.Full;

public partial class LMEPage : ContentPage
{
	public LMEPage()
	{
		InitializeComponent();

		BindingContext = new LMEViewModel();
	}
}