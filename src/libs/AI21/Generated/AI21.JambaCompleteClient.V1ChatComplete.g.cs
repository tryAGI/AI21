
#nullable enable

namespace AI21
{
    public partial class JambaCompleteClient
    {
        partial void PrepareV1ChatCompleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AI21.ChatRequest request);
        partial void PrepareV1ChatCompleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AI21.ChatRequest request);
        partial void ProcessV1ChatCompleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1ChatCompleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            global::AI21.ChatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1ChatCompleteArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::AI21.PathBuilder(
                path: "/studio/v1/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PrepareV1ChatCompleteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1ChatCompleteResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::AI21.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::AI21.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::AI21.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::AI21.ApiException<global::AI21.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessV1ChatCompleteResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::AI21.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::AI21.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="model">
        /// An enumeration.
        /// </param>
        /// <param name="messages">
        /// The previous messages in this chat, from oldest (index 0) to newest. Messages<br/>
        /// must be alternating `user`/`assistant` messages, optionally starting with a `system`<br/>
        /// message. For single turn interactions, this should be an optional `system` message,<br/>
        /// and a single `user` message. Maximum total size for the list is about 256K tokens.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="n">
        /// How many chat responses to generate. _Range: 1 – 16_ **Notes:**<br/>
        /// - If `n &gt; 1`, setting `temperature=0` will fail because all answers are guaranteed to be duplicates.<br/>
        /// - `n` must be 1 when `stream = True`<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to allow for each generated response message. Typically<br/>
        /// the best way to limit output length is by providing a length limit in the system<br/>
        /// prompt (for example, "limit your answers to three sentences"). _Range: 0 – 4096_<br/>
        /// Default Value: 4096
        /// </param>
        /// <param name="temperature">
        /// How much variation to provide in each answer. Setting this value to 0 guarantees the<br/>
        /// same response to the same question every time. Setting a higher value encourages more<br/>
        /// variation. Modifies the distribution from which tokens are sampled.<br/>
        /// [More information](https://docs.ai21.com/docs/sampling-from-language-models#temperature)<br/>
        /// _Range: 0.0 – 2.0_
        /// </param>
        /// <param name="topP">
        /// Limit the pool of next tokens in each step to the top N percentile of possible<br/>
        /// tokens, where 1.0 means the pool of all possible tokens, and 0.01 means the<br/>
        /// pool of only the most likely next tokens. [More information]<br/>
        /// (https://docs.ai21.com/docs/sampling-from-language-models#topp) _Range: 0 \&lt;= value \&lt;=1.0_<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="stop">
        /// End the message when the model generates one of these strings. The stop sequence<br/>
        /// is not included in the generated message. Each sequence can be up to 64K long, and<br/>
        /// can contain newlines as `\n` characters. Examples:<br/>
        /// - Single stop string with a word and a period: "monkeys."<br/>
        /// - Multiple stop strings and a newline: ["cat", "dog", " .", "####", "\n"]
        /// </param>
        /// <param name="stream">
        /// Whether or not to stream the result one token at a time using<br/>
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).<br/>
        /// This can be useful when waiting for long results where a long wait time for an<br/>
        /// answer can be problematic, such as a chatbot. If set to `True`, then `n` must<br/>
        /// be 1. A streaming response is different than the non-streaming response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mockResponse"></param>
        /// <param name="documents"></param>
        /// <param name="responseFormat"></param>
        /// <param name="guidedJson"></param>
        /// <param name="guidedDecodingBackend"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            global::AI21.ModelName model,
            global::System.Collections.Generic.IList<global::AI21.MessagesItem> messages,
            global::System.Collections.Generic.IList<global::AI21.ToolDefinition>? tools = default,
            int? n = default,
            int? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::AI21.MockResponseConfig? mockResponse = default,
            global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? documents = default,
            global::AI21.ResponseFormat? responseFormat = default,
            global::AI21.AnyOf<string, object>? guidedJson = default,
            string? guidedDecodingBackend = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.ChatRequest
            {
                Model = model,
                Messages = messages,
                Tools = tools,
                N = n,
                MaxTokens = maxTokens,
                Temperature = temperature,
                TopP = topP,
                Stop = stop,
                Stream = stream,
                MockResponse = mockResponse,
                Documents = documents,
                ResponseFormat = responseFormat,
                GuidedJson = guidedJson,
                GuidedDecodingBackend = guidedDecodingBackend,
            };

            return await V1ChatCompleteAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}