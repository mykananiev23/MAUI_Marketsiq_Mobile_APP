namespace MauiApp1.Controls;

public partial class FlyoutFooter : ContentView
{
	public FlyoutFooter()
	{
		InitializeComponent();
	}

	private async void OnLogOutHandler(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
		Shell.Current.FlyoutIsPresented = false;
	}
}