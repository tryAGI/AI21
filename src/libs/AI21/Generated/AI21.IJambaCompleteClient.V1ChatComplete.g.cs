#nullable enable

namespace AI21
{
    public partial interface IJambaCompleteClient
    {
        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            global::AI21.ChatRequest request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            global::AI21.ModelName model,
            global::System.Collections.Generic.IList<global::AI21.MessagesItem> messages,
            int? requestStartTime = default,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}