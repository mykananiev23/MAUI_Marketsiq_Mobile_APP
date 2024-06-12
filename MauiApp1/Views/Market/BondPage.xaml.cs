using MarketsIQ.ViewModels.Maket;
using SkiaSharp;

namespace MarketsIQ.Views.Market;

public partial class BondPage : ContentPage
{
	public BondPage()
	{
		InitializeComponent();

		BindingContext = new BondViewModel();
	}
}