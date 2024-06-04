using Quantower.API.Client.Models.Quotes;
using Quantower.API.Client;
using Quantower.API.Client.Models;
using System.Diagnostics.Metrics;
using Microsoft.Maui.Controls;
using System.Text;
using IdentityModel.OidcClient;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly OidcClient _client = default!;
        private string? _currentAccessToken;
        public readonly QApiClient _apiClient;
        public MainPage(OidcClient client, QApiClient _qApiClient)
        {
            InitializeComponent();

            _client = client;
            _apiClient = _qApiClient;
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
            CancellationToken token = new CancellationToken();
            var result = _apiClient.Connect(token);
            Label2.Text = "Connect: " + result.ErrorText;

            QInstrument[] instruments = GetInstruments(token);
            Label2.Text = "Total symbols count: " + instruments.Length;

            _apiClient.Quotes.MarketQuoteReceived += Quotes_MarketQuoteReceived;
            _apiClient.Quotes.Subscribe(instruments[0].Id, QMarketQuoteType.Trade);
        }

        private QInstrument[] GetInstruments(CancellationToken token)
        {
            return _apiClient.Instruments.GetInstruments(token).Value;
        }

        private void Quotes_MarketQuoteReceived(object sender, QEventArgs e)
        {
            if (e.MarketData is QTradeQuote qTrade)
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Label1.Text = $"Price: {qTrade.Price} Size: {qTrade.Size}";
                });
            }
        }

        private async void OnGotoMainView(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Market/Indices");
        }
    }
}
