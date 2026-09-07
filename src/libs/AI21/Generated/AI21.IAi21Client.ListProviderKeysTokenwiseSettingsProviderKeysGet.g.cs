#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// List Provider Keys<br/>
        /// The workspace's provider keys, masked.<br/>
        /// One endpoint, two shapes, mirroring the BFF: without ``provider`` it lists<br/>
        /// every key for the workspace; with one it returns that single key, or 404 if<br/>
        /// the workspace has none for it. The union response model is the honest<br/>
        /// declaration of that — see ``provider_keys/router.py::list_provider_keys``.<br/>
        /// ``provider`` is bounded here so an explicitly empty ``?provider=`` fails with<br/>
        /// 422 at this edge rather than making the round trip (the BFF rejects it too);<br/>
        /// omitting it entirely is the list case. It rides through on the forwarded query<br/>
        /// string — see ``tokenwise_service._build_gateway_request``.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.ProviderKeyOut>, global::AI21.ProviderKeyOut>> ListProviderKeysTokenwiseSettingsProviderKeysGetAsync(
            string? provider = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Provider Keys<br/>
        /// The workspace's provider keys, masked.<br/>
        /// One endpoint, two shapes, mirroring the BFF: without ``provider`` it lists<br/>
        /// every key for the workspace; with one it returns that single key, or 404 if<br/>
        /// the workspace has none for it. The union response model is the honest<br/>
        /// declaration of that — see ``provider_keys/router.py::list_provider_keys``.<br/>
        /// ``provider`` is bounded here so an explicitly empty ``?provider=`` fails with<br/>
        /// 422 at this edge rather than making the round trip (the BFF rejects it too);<br/>
        /// omitting it entirely is the list case. It rides through on the forwarded query<br/>
        /// string — see ``tokenwise_service._build_gateway_request``.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.ProviderKeyOut>, global::AI21.ProviderKeyOut>>> ListProviderKeysTokenwiseSettingsProviderKeysGetAsResponseAsync(
            string? provider = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}