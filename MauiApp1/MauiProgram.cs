using IdentityModel.OidcClient;
using MarketsIQ.Services;
using MarketsIQ.Views.Market;
using MarketsIQ.Views.Watchlist;
using Microsoft.Extensions.Logging;

namespace MarketsIQ
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

            //builder.Services
            //.AddSingleton(new OidcClient(new()
            //{
            //    Authority = "https://demo.duendesoftware.com",

            //    ClientId = "interactive.public",
            //    Scope = "openid profile api",
            //    RedirectUri = "myapp://callback",

            //    Browser = new LoginOAuthBrowser()
            //}));

            builder.Services.AddSingleton(new OidcClient(new()
            {
                Authority = "https://identity.data.marketsiq.co",

                ClientId = "MAUIClient",
                Scope = "openid profile email offline_access LicenceService",
                RedirectUri = "marketsiq://callback",

                Browser = new LoginOAuthBrowser()
            }));

            builder.Services.AddSingleton<MarketsIQService>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<IndicesPage>();
            builder.Services.AddSingleton<WatchlistPage>();

            return builder.Build();
        }
    }
}
