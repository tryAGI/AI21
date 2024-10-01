
#nullable enable

namespace AI21
{
    public partial class ChatClient
    {
        partial void PrepareV1J2UltraChatArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? model,
            global::AI21.LanguageStudioApiServerDataTypesJ2ChatChatRequest request);
        partial void PrepareV1J2UltraChatRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? model,
            global::AI21.LanguageStudioApiServerDataTypesJ2ChatChatRequest request);
        partial void ProcessV1J2UltraChatResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1J2UltraChatResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// j2-ultra chat
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ChatResponse> V1J2UltraChatAsync(
            global::AI21.LanguageStudioApiServerDataTypesJ2ChatChatRequest request,
            string? model = "j2-ultra",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1J2UltraChatArguments(
                httpClient: _httpClient,
                model: ref model,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/j2-ultra/chat",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("model", model) 
                ; 
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
            PrepareV1J2UltraChatRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                model: model,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1J2UltraChatResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1J2UltraChatResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::AI21.ChatResponse), JsonSerializerContext) as global::AI21.ChatResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// j2-ultra chat
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="system"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0.7
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 300
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ChatResponse> V1J2UltraChatAsync(
            global::System.Collections.Generic.IList<global::AI21.ChatMessage> messages,
            string system,
            string? model = "j2-ultra",
            global::AI21.Penalty? frequencyPenalty = default,
            global::AI21.Penalty? presencePenalty = default,
            global::AI21.Penalty? countPenalty = default,
            int? numResults = 1,
            double? temperature = 0.7,
            int? maxTokens = 300,
            int? minTokens = 0,
            double? topP = 1,
            int? topKReturn = 0,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AI21.LanguageStudioApiServerDataTypesJ2ChatChatRequest
            {
                Messages = messages,
                System = system,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                CountPenalty = countPenalty,
                NumResults = numResults,
                Temperature = temperature,
                MaxTokens = maxTokens,
                MinTokens = minTokens,
                TopP = topP,
                TopKReturn = topKReturn,
                StopSequences = stopSequences,
            };

            return await V1J2UltraChatAsync(
                model: model,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}