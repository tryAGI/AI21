
#nullable enable

namespace AI21
{
    public partial class ParaphraseClient
    {
        partial void PrepareV1ParaphrazeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            global::AI21.ParaphraseBody request);
        partial void PrepareV1ParaphrazeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
            global::AI21.ParaphraseBody request);
        partial void ProcessV1ParaphrazeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1ParaphrazeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Paraphrase
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900643
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1ParaphrazeAsync(
            global::AI21.ParaphraseBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1ParaphrazeArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/paraphrase",
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
            PrepareV1ParaphrazeRequest(
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
            ProcessV1ParaphrazeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1ParaphrazeResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Paraphrase
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900643
        /// </param>
        /// <param name="text"></param>
        /// <param name="style">
        /// Default Value: general
        /// </param>
        /// <param name="startIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="endIndex"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1ParaphrazeAsync(
            string text,
            int? requestStartTime = default,
            global::AI21.StyleType? style = default,
            int? startIndex = default,
            int? endIndex = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.ParaphraseBody
            {
                Text = text,
                Style = style,
                StartIndex = startIndex,
                EndIndex = endIndex,
            };

            return await V1ParaphrazeAsync(
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}