using MarketsIQ.ViewModels.Full;

namespace MarketsIQ.Views.Full;

public partial class FxINRPage : ContentPage
{
	public FxINRPage()
	{
		InitializeComponent();

		BindingContext = new INRViewModel();
	}
}