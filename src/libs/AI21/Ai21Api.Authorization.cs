using System.Net.Http.Headers;
using System.Text;

// ReSharper disable UnusedParameter.Local
// ReSharper disable MemberCanBeMadeStatic.Local

#pragma warning disable CA1822

namespace AI21;

public partial class Ai21Api
{
    private string ApiKey { get; } = string.Empty;

    private Task PrepareRequestAsync(HttpClient client, HttpRequestMessage request, string url, CancellationToken cancellationToken)
    {
        if (!string.IsNullOrWhiteSpace(ApiKey))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue(
                scheme: "Bearer",
                parameter: ApiKey);
        }
        
        return Task.CompletedTask;
    }
    
    private Task PrepareRequestAsync(HttpClient client, HttpRequestMessage request, StringBuilder builder, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
    
    private Task ProcessResponseAsync(HttpClient client, HttpResponseMessage message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
