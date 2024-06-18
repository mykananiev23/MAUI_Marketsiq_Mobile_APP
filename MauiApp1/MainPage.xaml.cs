using System.Text;
using IdentityModel.OidcClient;
using MarketsIQ.Services;
using MarketsIQ.Services.Quantower.API.Client;
using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.Quantower.API.Client.Models.Quotes;

namespace MarketsIQ
{
    public partial class MainPage : ContentPage
    {
        private readonly OidcClient _client = default!;
        private string _currentAccessToken = "Hm6RLP-d9EFDVI-edCfOKTQ8Rbg14nL7XjByuiruHiM";

        public QApiClient _apiClient;
        public MarketsIQService _connectService;
        public MainPage(OidcClient client, MarketsIQService connectService)
        {
            InitializeComponent();

            _client = client;
            _connectService = connectService;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            Label1.Text = "Login Clicked";

            var result = await _client.LoginAsync();

            if (result.IsError)
            {
                Label1.Text = result.Error;
                return;
            }

            _currentAccessToken = result.AccessToken;

            var sb = new StringBuilder(128);

            sb.AppendLine("claims:");
            foreach (var claim in result.User.Claims)
            {
                sb.AppendLine($"{claim.Type}: {claim.Value}");
            }

            sb.AppendLine();
            sb.AppendLine("access token:");
            sb.AppendLine(result.AccessToken);

            if (!string.IsNullOrWhiteSpace(result.RefreshToken))
            {
                sb.AppendLine();
                sb.AppendLine("refresh token:");
                sb.AppendLine(result.RefreshToken);
            }

            Label1.Text = sb.ToString();
        }

        private async void OnHandleConnectionTest(object sender, EventArgs e)
        {
            _connectService.InintConnectService(_currentAccessToken);
            await Shell.Current.GoToAsync("//Market/Indices");
        }

        private async void OnHandleGoToTestPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//FullPage/FxForwards");
        }
    }
}
