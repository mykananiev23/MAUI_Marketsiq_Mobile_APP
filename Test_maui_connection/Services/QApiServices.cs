using Quantower.API.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_maui_connection.Services
{
    class QApiServices
    {
        public static QApiClient _qApiClient;

        public QApiServices(string accessToken)
        {
            string dateEndpoint = @"https://data.marketsiq.co";

            _qApiClient = new QApiClient(new QClientConfig()
            {
                AccessToken = accessToken,
                GatewayEndpoint = dateEndpoint,
                ClientInfo = new QClientInfo()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Branding = "Markets.iq",
                    Version = new Version(1, 97, 0),
                    GetClientTime = () => DateTime.UtcNow,
                }
            });

            CancellationToken token = new CancellationToken();

            _qApiClient.Connect(token);
        }

        public QApiClient GetClient()
        {
            return _qApiClient;
        }
    }
}
