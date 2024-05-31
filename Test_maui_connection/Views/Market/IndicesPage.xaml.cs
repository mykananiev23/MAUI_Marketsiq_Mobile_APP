using Test_maui_connection.Models;

namespace Test_maui_connection;

public partial class IndicesPage : ContentPage
{
	public IndicesPage()
	{
		InitializeComponent();
	}

	async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
        MarketSymbol symbol = e.CurrentSelection.FirstOrDefault() as MarketSymbol;

		var navigationParameters = new Dictionary<string, object>
		{
			{ "MarketSymbol",  symbol }
		};

		await Shell.Current.GoToAsync($"Detail", navigationParameters);
	}
}