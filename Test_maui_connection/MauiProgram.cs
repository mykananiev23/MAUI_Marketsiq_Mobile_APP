using IdentityModel.OidcClient;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Test_maui_connection.Services;

namespace Test_maui_connection
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseSkiaSharp(true)
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton(new OidcClient(new(){
                Authority = "https://identity.data.marketsiq.co",

                ClientId = "MarketsIQVendor",
                Scope = "openid profile email LicenceService offline_access",
                RedirectUri = "myapp://callback",

                Browser = new LoginOAuthBrowser()
            }));

            builder.Services.AddSingleton<QApiServices>();

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
