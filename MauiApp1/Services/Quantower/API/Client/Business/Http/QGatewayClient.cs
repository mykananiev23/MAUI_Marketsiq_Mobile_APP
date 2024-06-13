using MarketsIQ.Services.Quantower.API.Client.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    public class QGatewayClient : QHttpClient
    {
        public QGatewayClient(string baseEndpoint, QClientConfig clientConfig)
            : base(baseEndpoint, clientConfig)
        {
        }

        public QOperationResult<string> GetIdentityEndpoint(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<string>(HttpMethod.Get, "api/v1/gateway/identity_endpoint", cancellationToken);
        }

        public QOperationResult<Dictionary<string, string>> GetEndpoints(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<Dictionary<string, string>>(HttpMethod.Get, "api/v1/gateway/get_endpoints", cancellationToken);
        }
    }
}
