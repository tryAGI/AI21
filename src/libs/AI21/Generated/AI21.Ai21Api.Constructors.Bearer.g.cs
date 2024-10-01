
#nullable enable

namespace AI21
{
    public sealed partial class Ai21Api
    {
        /// <inheritdoc cref="Ai21Api(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::AI21.EndPointAuthorization}?)"/>
        public Ai21Api(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::AI21.EndPointAuthorization>? authorizations = null) : this(httpClient, baseUri, authorizations)
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