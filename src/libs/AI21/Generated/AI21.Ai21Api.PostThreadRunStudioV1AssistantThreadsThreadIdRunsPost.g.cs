
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PreparePostThreadRunStudioV1AssistantThreadsThreadIdRunsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            global::AI21.PostThreadRunRequest request);
        partial void PreparePostThreadRunStudioV1AssistantThreadsThreadIdRunsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            global::AI21.PostThreadRunRequest request);
        partial void ProcessPostThreadRunStudioV1AssistantThreadsThreadIdRunsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostThreadRunStudioV1AssistantThreadsThreadIdRunsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Post Thread Run
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.PostThreadRunResponse> PostThreadRunStudioV1AssistantThreadsThreadIdRunsPostAsync(
            string threadId,
            global::AI21.PostThreadRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePostThreadRunStudioV1AssistantThreadsThreadIdRunsPostArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/assistant/threads/{threadId}/runs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::AI21.SourceGenerationContext.Default.PostThreadRunRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePostThreadRunStudioV1AssistantThreadsThreadIdRunsPostRequest(
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
            ProcessPostThreadRunStudioV1AssistantThreadsThreadIdRunsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPostThreadRunStudioV1AssistantThreadsThreadIdRunsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.PostThreadRunResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Post Thread Run
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="assistantId"></param>
        /// <param name="description"></param>
        /// <param name="optimization">
        /// An enumeration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.PostThreadRunResponse> PostThreadRunStudioV1AssistantThreadsThreadIdRunsPostAsync(
            string threadId,
            string assistantId,
            string description,
            global::AI21.RunOptimization optimization,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AI21.PostThreadRunRequest
            {
                AssistantId = assistantId,
                Description = description,
                Optimization = optimization,
            };

            return await PostThreadRunStudioV1AssistantThreadsThreadIdRunsPostAsync(
                threadId: threadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}