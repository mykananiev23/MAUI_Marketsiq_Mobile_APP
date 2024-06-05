using MauiApp1.Services;
using MauiApp1.ViewModels.Maket;

namespace MauiApp1.Views.Market;

public partial class IndicesPage : ContentPage
{
	public IndicesPage(MarketsIQService connectService)
	{
		InitializeComponent();

		BindingContext = new IndicesViewModel(connectService);
	}
}