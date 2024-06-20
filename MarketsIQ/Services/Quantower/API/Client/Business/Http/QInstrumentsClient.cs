using System.Web;
using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.Quantower.API.Client.Models.TradingSessions;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    public class QInstrumentsClient : QHttpClient
    {
        public QInstrumentsClient(string baseEndpoint, QClientConfig clientConfig)
            : base(baseEndpoint, clientConfig)
        {
        }

        public QOperationResult<QInstrument[]> GetInstruments(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<QInstrument[]>(HttpMethod.Get, "api/v1/instruments", cancellationToken);
        }

        public QOperationResult<QExchange[]> GetExchanges(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<QExchange[]>(HttpMethod.Get, "api/v1/exchanges", cancellationToken);
        }

        public QOperationResult<QSessionsContainer[]> GetSessions(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<QSessionsContainer[]>(HttpMethod.Get, "api/v2/sessions", cancellationToken);
        }

        public QOperationResult<QInstrument> FindInstrument(int id, CancellationToken cancellationToken)
        {
            return MakeHttpRequest<QInstrument>(HttpMethod.Get, $"/api/v2/instruments/find?id={id}", cancellationToken);
        }

        public QOperationResult<QInstrument> FindInstrument(string localId, string feedName, CancellationToken cancellationToken)
        {
            return MakeHttpRequest<QInstrument>(HttpMethod.Get, "/api/v2/instruments/find?localId=" + HttpUtility.UrlEncode(localId) + "&feedName=" + HttpUtility.UrlEncode(feedName), cancellationToken);
        }
    }
}
