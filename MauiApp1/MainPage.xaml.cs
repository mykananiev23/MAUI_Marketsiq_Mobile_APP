using Quantower.API.Client.Models.Quotes;
using Quantower.API.Client;
using Quantower.API.Client.Models;
using System.Diagnostics.Metrics;
using Microsoft.Maui.Controls;
using System.Text;
using IdentityModel.OidcClient;
using MauiApp1.Services;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly OidcClient _client = default!;
        private string _currentAccessToken = "9I2DxcKL3dHrggvRzwOmB-GWHEBWCvNq4az2r1F_EtM";
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

        private void OnHandleConnectionTest(object sender, EventArgs e)
        {
            _connectService.InintConnectService(_currentAccessToken);
            _apiClient = _connectService.GetApiClient();
            QInstrument[] instruments = _connectService.GetInstruments();
            Label2.Text = "Total symbols count: " + instruments.Length;

            _apiClient.Quotes.MarketQuoteReceived += Quotes_MarketQuoteReceived;
            _apiClient.Quotes.Subscribe(instruments[0].Id, QMarketQuoteType.Trade);
        }

        private void Quotes_MarketQuoteReceived(object sender, QEventArgs e)
        {
            if (e.MarketData is QTradeQuote qTrade)
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Label1.Text = $"Id: {qTrade.InstrumentId} Price: {qTrade.Price} Size: {qTrade.Size}";
                });
            }
        }

        private async void OnGotoMainView(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Market/Indices");
        }
    }
}
