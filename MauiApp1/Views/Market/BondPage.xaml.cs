using MarketsIQ.ViewModels.Maket;
using SkiaSharp;

namespace MauiApp1.Views.Market;

public partial class BondPage : ContentPage
{
	public BondPage()
	{
		InitializeComponent();

		BindingContext = new BondViewModel();
	}
}