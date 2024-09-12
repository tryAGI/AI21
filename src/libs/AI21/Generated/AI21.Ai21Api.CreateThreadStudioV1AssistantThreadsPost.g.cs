
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareCreateThreadStudioV1AssistantThreadsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AI21.CreateThreadRequest request);
        partial void PrepareCreateThreadStudioV1AssistantThreadsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AI21.CreateThreadRequest request);
        partial void ProcessCreateThreadStudioV1AssistantThreadsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateThreadStudioV1AssistantThreadsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Thread
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.CreateThreadResponse> CreateThreadStudioV1AssistantThreadsPostAsync(
            global::AI21.CreateThreadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateThreadStudioV1AssistantThreadsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/studio/v1/assistant/threads", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::AI21.SourceGenerationContext.Default.CreateThreadRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateThreadStudioV1AssistantThreadsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateThreadStudioV1AssistantThreadsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateThreadStudioV1AssistantThreadsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.CreateThreadResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Thread
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.CreateThreadResponse> CreateThreadStudioV1AssistantThreadsPostAsync(
            global::System.Collections.Generic.IList<global::AI21.ThreadMessage>? messages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AI21.CreateThreadRequest
            {
                Messages = messages,
            };

            return await CreateThreadStudioV1AssistantThreadsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}