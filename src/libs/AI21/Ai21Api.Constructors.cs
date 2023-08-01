namespace AI21;

/// <summary>
/// Class providing methods for API access.
/// </summary>
public partial class Ai21Api
{
    /// <summary>
    /// Sets the selected apiKey as a default header for the HttpClient.
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="httpClient"></param>
    public Ai21Api(string apiKey, HttpClient httpClient) : this(httpClient)
    {
        ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
    }
}
