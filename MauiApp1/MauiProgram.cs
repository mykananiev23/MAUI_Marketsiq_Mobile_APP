using IdentityModel.OidcClient;
using MauiApp1.Services;
using MauiApp1.Views.Market;
using Microsoft.Extensions.Logging;

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

            builder.Services.AddSingleton<MarketsIQService>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<IndicesPage>();

            return builder.Build();
        }
    }
}
