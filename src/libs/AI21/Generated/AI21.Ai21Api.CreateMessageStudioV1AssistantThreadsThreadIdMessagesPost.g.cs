
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            global::AI21.CreateMessageRequest request);
        partial void PrepareCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            global::AI21.CreateMessageRequest request);
        partial void ProcessCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Message
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.CreateMessageResponse> CreateMessageStudioV1AssistantThreadsThreadIdMessagesPostAsync(
            string threadId,
            global::AI21.CreateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/assistant/threads/{threadId}/messages", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::AI21.SourceGenerationContext.Default.CreateMessageRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateMessageStudioV1AssistantThreadsThreadIdMessagesPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.CreateMessageResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Message
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="role">
        /// The role of an individual message.<br/>
        /// - `user`:  Input provided by the user. Any instructions given here that conflict<br/>
        ///   with instructions given in the `system` prompt take precedence over the `system`<br/>
        ///   prompt instructions.<br/>
        /// - `assistant`:  Response generated by the model.<br/>
        /// - `system`:  Initial instructions provided to the system to provide general guidance<br/>
        ///   on the tone and voice of the generated message. An initial system message is<br/>
        ///   optional but recommended to provide guidance on the tone of the chat. For<br/>
        ///   example, "You are a helpful chatbot with a background in earth sciences and a<br/>
        ///   charming French accent."
        /// </param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.CreateMessageResponse> CreateMessageStudioV1AssistantThreadsThreadIdMessagesPostAsync(
            string threadId,
            string role,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AI21.CreateMessageRequest
            {
                Role = role,
                Content = content,
            };

            return await CreateMessageStudioV1AssistantThreadsThreadIdMessagesPostAsync(
                threadId: threadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}