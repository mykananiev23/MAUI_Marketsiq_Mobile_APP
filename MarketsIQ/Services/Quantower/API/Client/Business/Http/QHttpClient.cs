using IdentityModel.Client;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;
using MarketsIQ.Services.Quantower.API.Client.Models;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    public abstract class QHttpClient : IDisposable
    {
        private const int DEFAULT_THROTTLING_DELAY_MS = 1000;

        protected const int HISTORY_ITEMS_PER_REQUEST = 50000;

        protected const int VOLUME_ANALYSIS_ITEMS_PER_REQUEST = 1000;

        private readonly HttpClient httpClient;

        private readonly QClientInfo clientInfo;

        protected QHttpClient(string baseEndpoint, QClientConfig clientConfig)
        {
            if (!baseEndpoint.EndsWith("/"))
            {
                baseEndpoint += "/";
            }

            clientInfo = clientConfig.ClientInfo;
            httpClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
            })
            {
                BaseAddress = new Uri(baseEndpoint)
            };
            httpClient.DefaultRequestHeaders.AcceptEncoding.Add(StringWithQualityHeaderValue.Parse("gzip"));
            httpClient.DefaultRequestHeaders.Add("X-ClientId", clientInfo.Id);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.SetBearerToken(clientConfig.AccessToken);
        }

        protected QOperationResult<T[]> PaginationLoading<T>(Func<int, QOperationResult<T[]>> loadPageFunc, int itemsPerRequest, CancellationToken cancellationToken)
        {
            List<T> list = new List<T>();
            bool flag = true;
            int num = 1;
            while (flag && !cancellationToken.IsCancellationRequested)
            {
                QOperationResult<T[]> qOperationResult = loadPageFunc(num);
                if (!qOperationResult.IsSuccess)
                {
                    return qOperationResult;
                }

                if (!qOperationResult.Value.Any() || qOperationResult.Value.Length < itemsPerRequest)
                {
                    flag = false;
                }

                list.AddRange(qOperationResult.Value);
                num++;
            }

            return QOperationResult<T[]>.CreateSuccess(list.ToArray());
        }

        protected QOperationResult<T> MakeHttpRequest<T>(HttpMethod method, string endpoint, CancellationToken cancellationToken)
        {
            return MakeHttpRequest<T>(messageFactory, cancellationToken);
            HttpRequestMessage messageFactory()
            {
                return new HttpRequestMessage(method, endpoint);
            }
        }

        private HttpRequestMessage PrepareMessage(HttpRequestMessage message)
        {
            if (clientInfo != null)
            {
                if (clientInfo.Branding != null)
                {
                    message.Headers.Add("X-Client-Branding", HeaderDataEncryptor.Encrypt(clientInfo.Branding));
                }

                if (clientInfo.Version != null)
                {
                    message.Headers.Add("X-Client-Version", HeaderDataEncryptor.Encrypt(clientInfo.Version.ToString()));
                }
            }

            long num = new DateTimeOffset(clientInfo.GetClientTime()).ToUnixTimeSeconds();
            message.Headers.Add("X-Client-Time", HeaderDataEncryptor.Encrypt(num.ToString()));
            return message;
        }

        protected QOperationResult<T> MakeHttpRequest<T>(Func<HttpRequestMessage> messageFactory, CancellationToken cancellationToken)
        {
            QOperationResult<T> qOperationResult = null;
            try
            {
                HttpRequestMessage request = PrepareMessage(messageFactory());
                HttpResponseMessage result = httpClient.SendAsync(request, cancellationToken).Result;
                switch (result.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        qOperationResult = QOperationResult<T>.CreateError("Unauthorized");
                        break;
                    case HttpStatusCode.TooManyRequests:
                        if (result.Headers.RetryAfter == null || !result.Headers.RetryAfter.Delta.HasValue)
                        {
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            double num = result.Headers.RetryAfter.Delta.Value.TotalSeconds + 1.0;
                            Thread.Sleep((int)num * 1000);
                        }

                        return MakeHttpRequest<T>(messageFactory, cancellationToken);
                    default:
                        if (result.IsSuccessStatusCode)
                        {
                            string result2 = result.Content.ReadAsStringAsync().Result;
                            qOperationResult = JsonConvert.DeserializeObject<QOperationResult<T>>(result2);
                        }
                        else
                        {
                            qOperationResult = QOperationResult<T>.CreateError($"{result.StatusCode} {result.ReasonPhrase}");
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                qOperationResult = QOperationResult<T>.CreateError(ex.InnerException?.Message ?? ex.Message);
            }

            return qOperationResult;
        }

        public virtual void Dispose()
        {
            httpClient?.Dispose();
        }
    }
}
