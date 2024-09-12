
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId);
        partial void PrepareGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId);
        partial void ProcessGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Messages
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.GetMessagesResponse> GetMessagesStudioV1AssistantThreadsThreadIdMessagesGetAsync(
            string threadId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetArguments(
                httpClient: _httpClient,
                threadId: ref threadId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/assistant/threads/{threadId}/messages", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetMessagesStudioV1AssistantThreadsThreadIdMessagesGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.GetMessagesResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}