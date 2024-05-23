using IdentityModel.Client;
using IdentityModel.OidcClient.Browser;

namespace Test_maui_connection;

public class LoginOAuthBrowser: IdentityModel.OidcClient.Browser.IBrowser
{
    public async Task<BrowserResult> InvokeAsync(BrowserOptions options, CancellationToken cancellationToken = default)
    {
        try
        {
            var result = await WebAuthenticator.Default.AuthenticateAsync(
                new Uri(options.StartUrl),
                new Uri(options.EndUrl));

            Console.WriteLine(result.ToString());

            var url = new RequestUrl("myapp://callback")
                .Create(new Parameters(result.Properties));

            return new BrowserResult
            {
                Response = url,
                ResultType = BrowserResultType.Success,
            };
        }
        catch (TaskCanceledException) 
        {
            return new BrowserResult
            {
                ResultType = BrowserResultType.UserCancel,
            };
        }
    }
}
