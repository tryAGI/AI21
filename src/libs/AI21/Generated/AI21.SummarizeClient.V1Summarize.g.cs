
#nullable enable

namespace AI21
{
    public partial class SummarizeClient
    {
        partial void PrepareV1SummarizeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            global::AI21.SummarizeBody request);
        partial void PrepareV1SummarizeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
            global::AI21.SummarizeBody request);
        partial void ProcessV1SummarizeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1SummarizeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730990580663
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.SummarizationResponse> V1SummarizeAsync(
            global::AI21.SummarizeBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1SummarizeArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/summarize",
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
            PrepareV1SummarizeRequest(
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
            ProcessV1SummarizeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1SummarizeResponseContent(
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
                global::AI21.SummarizationResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730990580663
        /// </param>
        /// <param name="source"></param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="summaryMethod">
        /// An enumeration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.SummarizationResponse> V1SummarizeAsync(
            string source,
            global::AI21.DocumentType sourceType,
            int? requestStartTime = default,
            string? focus = default,
            global::AI21.SummaryMethod? summaryMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.SummarizeBody
            {
                Source = source,
                SourceType = sourceType,
                Focus = focus,
                SummaryMethod = summaryMethod,
            };

            return await V1SummarizeAsync(
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}