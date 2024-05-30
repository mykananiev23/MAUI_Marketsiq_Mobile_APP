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
		Symbol symbol = e.CurrentSelection.FirstOrDefault() as Symbol;

		var navigationParameters = new Dictionary<string, object>
		{
			{ "Symbol",  symbol }
		};

		await Shell.Current.GoToAsync($"Detail", navigationParameters);
	}
}