using Android.Telephony;
using IdentityModel.OidcClient;
using Quantower.API.Client;
using Quantower.API.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class MarketsIQService
    {
        public static QApiClient qApiClient;

        public static QInstrument[] instruments;

        public void InintConnectService(string accessToken)
        {
            accessToken = "Uq5DNlNwIgG25uhXW0aots-878_9UvbdKc8lchFFDJg";
            qApiClient = new QApiClient(new QClientConfig()
            {
                AccessToken = accessToken,
                GatewayEndpoint = "https://data.marketsiq.co",
                ClientInfo = new QClientInfo
                {
                    Id = Guid.NewGuid().ToString(),
                    Branding = "Markets.iq",
                    Version = new Version(1, 97, 0),
                    GetClientTime = () => DateTime.UtcNow,
                }
            });

            CancellationToken token = new CancellationToken();
            qApiClient.Connect(token);

            instruments = _prevGetInstruments(token);
        }

        public QApiClient GetApiClient()
        {
            return qApiClient;
        }

        private QInstrument[] _prevGetInstruments(CancellationToken token)
        {
            return qApiClient.Instruments.GetInstruments(token).Value;
        }

        public QInstrument[] GetInstruments()
        {
            return instruments;
        }
    }
}
