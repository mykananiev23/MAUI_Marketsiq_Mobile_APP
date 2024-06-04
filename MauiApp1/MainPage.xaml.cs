using Quantower.API.Client.Models.Quotes;
using Quantower.API.Client;
using Quantower.API.Client.Models;
using System.Diagnostics.Metrics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public readonly QApiClient _apiClient;
        public MainPage(QApiClient _qApiClient)
        {
            InitializeComponent();

            _apiClient = _qApiClient;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            var prevLoginText = LoginButton.Text;
        }

        private void OnGotoMainView(object sender, EventArgs e)
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
    }

}
