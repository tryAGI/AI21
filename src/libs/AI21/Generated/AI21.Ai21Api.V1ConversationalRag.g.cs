
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareV1ConversationalRagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            global::AI21.ConversationalRagConfig request);
        partial void PrepareV1ConversationalRagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
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
        /// <param name="requestStartTime">
        /// Default Value: 1730898970831
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ConversationalRagResult> V1ConversationalRagAsync(
            global::AI21.ConversationalRagConfig request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1ConversationalRagArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/conversational-rag",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1ConversationalRagRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestStartTime: requestStartTime,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1ConversationalRagResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1ConversationalRagResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::AI21.ConversationalRagResult.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Conversational Rag
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898970831
        /// </param>
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
            int? requestStartTime = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            int? maxSegments = default,
            global::AI21.ConversationalRagConfigRetrievalStrategy? retrievalStrategy = default,
            double? retrievalSimilarityThreshold = default,
            int? maxNeighbors = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.ConversationalRagConfig
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
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}