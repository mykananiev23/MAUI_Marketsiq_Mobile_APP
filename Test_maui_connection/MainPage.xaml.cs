using IdentityModel.OidcClient;
using Quantower.API.Client;
using Test_maui_connection.Controls;

namespace Test_maui_connection
{
    public partial class MainPage : ContentPage
    {
        private readonly OidcClient _client = default!;

        public MainPage(OidcClient client)
        {
            InitializeComponent();

            _client = client;
            AcessTokenField.Text = Preferences.Get("ConnectionAccessToken", string.Empty);
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            var prevLoginText = LoginButton.Text;
            LoginButton.Text = "Loading";

            var accessToken = AcessTokenField.Text;

            Preferences.Set("ConnectionAccessToken", accessToken);


            CancellationToken token = new CancellationToken();

            QApiServices _qApiSservices = new QApiServices(accessToken);
            QApiClient _cClient = _qApiSservices._qApiClient;

            _cClient.Connect(token);

            LoginButton.Text = "Connecting Success!";
        }

        private async void OnGotoMainView(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Market/Indices");
        }
    }
}
