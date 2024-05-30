using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Test_maui_connection.ViewModels;

namespace Test_maui_connection;

public partial class DetailMarket : ContentPage
{
	public DetailMarket()
	{
		InitializeComponent();

		BindingContext = new MarketViewModel();
	}
}