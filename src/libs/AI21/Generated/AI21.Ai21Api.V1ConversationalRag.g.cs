
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareV1ConversationalRagArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AI21.ConversationalRagConfig request);
        partial void PrepareV1ConversationalRagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AI21.ConversationalRagConfig request);
        partial void ProcessV1ConversationalRagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1ConversationalRagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Conversational Rag
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ConversationalRagResult> V1ConversationalRagAsync(
            global::AI21.ConversationalRagConfig request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1ConversationalRagArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/conversational-rag",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1ConversationalRagRequest(
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
            ProcessV1ConversationalRagResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1ConversationalRagResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::AI21.ConversationalRagResult), JsonSerializerContext) as global::AI21.ConversationalRagResult ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Conversational Rag
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="fileIds"></param>
        /// <param name="maxSegments">
        /// Default Value: 15
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold">
        /// Default Value: 0.8
        /// </param>
        /// <param name="maxNeighbors"></param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 0.98
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ConversationalRagResult> V1ConversationalRagAsync(
            global::System.Collections.Generic.IList<global::AI21.Message> messages,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            int? maxSegments = 15,
            global::AI21.ConversationalRagConfigRetrievalStrategy? retrievalStrategy = global::AI21.ConversationalRagConfigRetrievalStrategy.Default,
            double? retrievalSimilarityThreshold = 0.8,
            int? maxNeighbors = default,
            double? hybridSearchAlpha = 0.98,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AI21.ConversationalRagConfig
            {
                Messages = messages,
                Path = path,
                Labels = labels,
                FileIds = fileIds,
                MaxSegments = maxSegments,
                RetrievalStrategy = retrievalStrategy,
                RetrievalSimilarityThreshold = retrievalSimilarityThreshold,
                MaxNeighbors = maxNeighbors,
                HybridSearchAlpha = hybridSearchAlpha,
            };

            return await V1ConversationalRagAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}