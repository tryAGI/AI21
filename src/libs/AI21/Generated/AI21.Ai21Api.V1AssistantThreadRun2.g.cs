
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareV1AssistantThreadRun2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            ref string runId,
            global::AI21.SubmitToolOutputsRequest request);
        partial void PrepareV1AssistantThreadRun2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            string runId,
            global::AI21.SubmitToolOutputsRequest request);
        partial void ProcessV1AssistantThreadRun2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1AssistantThreadRun2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Submit Tool Outputs
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.SubmitToolOutputsResponse> V1AssistantThreadRun2Async(
            string threadId,
            string runId,
            global::AI21.SubmitToolOutputsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1AssistantThreadRun2Arguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/studio/v1/assistant/threads/{threadId}/runs/{runId}/submit_tool_outputs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::AI21.SourceGenerationContext.Default.SubmitToolOutputsRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1AssistantThreadRun2Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                runId: runId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1AssistantThreadRun2Response(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1AssistantThreadRun2ResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AI21.SourceGenerationContext.Default.SubmitToolOutputsResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Submit Tool Outputs
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="toolOutputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.SubmitToolOutputsResponse> V1AssistantThreadRun2Async(
            string threadId,
            string runId,
            global::System.Collections.Generic.IList<global::AI21.ToolCallOutput> toolOutputs,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AI21.SubmitToolOutputsRequest
            {
                ToolOutputs = toolOutputs,
            };

            return await V1AssistantThreadRun2Async(
                threadId: threadId,
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}