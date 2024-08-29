
#nullable enable

namespace AI21
{
    public sealed partial class Ai21Api
    {
        /// <inheritdoc cref="Ai21Api(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public Ai21Api(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}