using IdentityModel.OidcClient;
using Microsoft.Extensions.Logging;
using Quantower.API.Client;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton(new OidcClient(new()
            {
                Authority = "https://demo.duendesoftware.com",

                ClientId = "interactive.public",
                Scope = "openid profile api",
                RedirectUri = "myapp://callback",

                Browser = new LoginOAuthBrowser()
            }));

            builder.Services.AddSingleton(new QApiClient(new QClientConfig()
            {
                AccessToken = "tA_Yghi0y17eBGonNcJJeNKVYt78ef7SpgPAzu96FlM",
                GatewayEndpoint = "https://data.marketsiq.co",
                ClientInfo = new QClientInfo
                {
                    Id = Guid.NewGuid().ToString(),
                    Branding = "Markets.iq",
                    Version = new Version(1, 97, 0),
                    GetClientTime = () => DateTime.UtcNow,
                }
            }));

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
