
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            ref string runId);
        partial void PrepareGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            string runId);
        partial void ProcessGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Thread Run Result
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.GetThreadRunResponse> GetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetAsync(
            string threadId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                runId: ref runId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/assistant/threads/{threadId}/runs/{runId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                runId: runId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetThreadRunResultStudioV1AssistantThreadsThreadIdRunsRunIdGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.GetThreadRunResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}