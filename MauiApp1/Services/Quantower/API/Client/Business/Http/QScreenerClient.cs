using System.Text;
using Newtonsoft.Json;
using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    public class QScreenerClient : QHttpClient
    {
        public QScreenerClient(string baseEndpoint, QClientConfig clientConfig)
            : base(baseEndpoint, clientConfig)
        {
        }

        public QOperationResult<QScreenerOperand[]> GetScreenerOperands(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<QScreenerOperand[]>(HttpMethod.Get, "api/v1/operands", cancellationToken);
        }

        public QOperationResult<string[]> GetScreenerFiltration(QScreenerExpressionList[] expressionLists, CancellationToken cancellationToken)
        {
            return MakeHttpRequest<string[]>(messageFactory, cancellationToken);
            HttpRequestMessage messageFactory()
            {
                QScreenerExpressionRequest value = new QScreenerExpressionRequest
                {
                    ExpressionList = expressionLists
                };
                string content = JsonConvert.SerializeObject(value);
                return new HttpRequestMessage(HttpMethod.Post, "api/v1/filter")
                {
                    Content = new StringContent(content, Encoding.UTF8, "application/json")
                };
            }
        }
    }
}
