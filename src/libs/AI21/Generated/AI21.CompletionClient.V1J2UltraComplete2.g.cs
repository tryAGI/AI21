
#nullable enable

namespace AI21
{
    public partial class CompletionClient
    {
        partial void PrepareV1J2UltraComplete2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string customModelName,
            ref string? customModelType,
            ref int? requestStartTime,
            global::AI21.CompletionBody request);
        partial void PrepareV1J2UltraComplete2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string customModelName,
            string? customModelType,
            int? requestStartTime,
            global::AI21.CompletionBody request);
        partial void ProcessV1J2UltraComplete2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1J2UltraComplete2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Custom j2-ultra complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1J2UltraComplete2Async(
            string customModelName,
            global::AI21.CompletionBody request,
            string? customModelType = default,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1J2UltraComplete2Arguments(
                httpClient: HttpClient,
                customModelName: ref customModelName,
                customModelType: ref customModelType,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/j2-ultra/{customModelName}/complete",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("custom_model_type", customModelType) 
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
            PrepareV1J2UltraComplete2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                customModelName: customModelName,
                customModelType: customModelType,
                requestStartTime: requestStartTime,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1J2UltraComplete2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1J2UltraComplete2ResponseContent(
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
        /// Custom j2-ultra complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 16
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="minP">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences"></param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="epoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1J2UltraComplete2Async(
            string customModelName,
            string prompt,
            string? customModelType = default,
            int? requestStartTime = default,
            int? numResults = default,
            int? maxTokens = default,
            int? minTokens = default,
            double? temperature = default,
            double? topP = default,
            double? minP = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topKReturn = default,
            object? logitBias = default,
            global::AI21.Penalty? frequencyPenalty = default,
            global::AI21.Penalty? presencePenalty = default,
            global::AI21.Penalty? countPenalty = default,
            int? epoch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.CompletionBody
            {
                Prompt = prompt,
                NumResults = numResults,
                MaxTokens = maxTokens,
                MinTokens = minTokens,
                Temperature = temperature,
                TopP = topP,
                MinP = minP,
                StopSequences = stopSequences,
                TopKReturn = topKReturn,
                LogitBias = logitBias,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                CountPenalty = countPenalty,
                Epoch = epoch,
            };

            return await V1J2UltraComplete2Async(
                customModelName: customModelName,
                customModelType: customModelType,
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}