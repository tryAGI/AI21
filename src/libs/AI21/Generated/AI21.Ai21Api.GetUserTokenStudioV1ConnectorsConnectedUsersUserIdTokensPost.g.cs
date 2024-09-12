
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId);
        partial void PrepareGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId);
        partial void ProcessGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get User Token
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ConnectorsToken> GetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostArguments(
                httpClient: _httpClient,
                userId: ref userId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/connectors/connected-users/{userId}/tokens", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetUserTokenStudioV1ConnectorsConnectedUsersUserIdTokensPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.ConnectorsToken) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}