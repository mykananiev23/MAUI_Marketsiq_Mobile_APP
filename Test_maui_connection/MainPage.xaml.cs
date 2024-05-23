using IdentityModel.OidcClient;

namespace Test_maui_connection
{
    public partial class MainPage : ContentPage
    {
        private readonly OidcClient _client = default!;
        private string? _currentAccessToken;

        public MainPage(OidcClient client)
        {
            InitializeComponent();

            _client = client;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            LoginButton.Text = "Loading";

            var result = await _client.LoginAsync();

            if (result.IsError)
            {
                return;
            }

            LoginButton.Text = "Just a Seconds...";

            _currentAccessToken = result.AccessToken;
        }

        private async void OnGotoMainView(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Market/Indices");
        }
    }
}
