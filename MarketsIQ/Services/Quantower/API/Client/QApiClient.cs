using System.Net;
using System.Net.Sockets;
using MarketsIQ.Services.Quantower.API.Client.Business.Http;
using MarketsIQ.Services.Quantower.API.Client.Business.Sockets;
using MarketsIQ.Services.Quantower.API.Client.Models;

namespace MarketsIQ.Services.Quantower.API.Client
{
    public class QApiClient
    {
        private readonly Lazy<QQuotesClient> quotesClient;

        private readonly QGatewayClient gatewayClient;

        private readonly QClientConfig config;

        public QInstrumentsClient Instruments { get; private set; }

        public QHistoryClient History { get; private set; }

        public QVolumeAnalysisClient VolumeAnalysis { get; private set; }

        public QScreenerClient Screener { get; private set; }

        public QQuotesClient Quotes => quotesClient.Value;

        public QApiClient(QClientConfig config)
        {
            if (string.IsNullOrEmpty(config.GatewayEndpoint))
            {
                throw new ArgumentNullException("GatewayEndpoint");
            }

            this.config = config;
            quotesClient = new Lazy<QQuotesClient>();
            gatewayClient = new QGatewayClient(config.GatewayEndpoint, config);
        }

        public QOperationResult<string> Connect(CancellationToken cancellationToken)
        {
            QOperationResult<string> result;
            try
            {
                QOperationResult<Dictionary<string, string>> endpoints = gatewayClient.GetEndpoints(cancellationToken);
                if (!endpoints.IsSuccess)
                {
                    return QOperationResult<string>.CreateError(endpoints.ErrorText);
                }

                if (cancellationToken.IsCancellationRequested)
                {
                    return QOperationResult<string>.CreateCancelled();
                }

                if (endpoints.Value.TryGetValue("instruments", out var value))
                {
                    Instruments = new QInstrumentsClient(value, config);
                }

                if (endpoints.Value.TryGetValue("history", out var value2))
                {
                    History = new QHistoryClient(value2, config);
                    VolumeAnalysis = new QVolumeAnalysisClient(value2, config);
                }

                if (endpoints.Value.TryGetValue("quotes", out var value3))
                {
                    Uri uri = new Uri(value3);
                    DnsEndPoint endPoint = new DnsEndPoint(uri.Host, uri.Port, AddressFamily.InterNetwork);
                    Quotes.Connect(endPoint, cancellationToken);
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return QOperationResult<string>.CreateCancelled();
                    }

                    QOperationResult<string> qOperationResult = Quotes.Logon(config.AccessToken, cancellationToken);
                    if (!qOperationResult.IsSuccess)
                    {
                        return QOperationResult<string>.CreateError(qOperationResult.ErrorText);
                    }
                }

                if (endpoints.Value.TryGetValue("screener", out var value4))
                {
                    Screener = new QScreenerClient(value4, config);
                }

                result = QOperationResult<string>.CreateSuccess(null);
            }
            catch (Exception ex)
            {
                result = QOperationResult<string>.CreateError(ex.InnerException?.Message ?? ex.Message);
            }

            return result;
        }

        public void Disconnect()
        {
            gatewayClient?.Dispose();
            Instruments?.Dispose();
            History?.Dispose();
            if (quotesClient.IsValueCreated)
            {
                Quotes.Logout();
            }
        }

        public bool AdditionalPing(CancellationToken token)
        {
            QOperationResult<Dictionary<string, string>> endpoints = gatewayClient.GetEndpoints(token);
            return endpoints.IsSuccess;
        }
    }
}
