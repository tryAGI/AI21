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
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            string authorization,
            global::AI21.LanguageStudioApiServerDataTypesChatChatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="model">
        /// An enumeration.
        /// </param>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="tools"></param>
        /// <param name="n">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 4096
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="stop"></param>
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
            string authorization,
            global::AI21.ModelName model,
            global::System.Collections.Generic.IList<global::AI21.MessagesItem> messages,
            global::System.Collections.Generic.IList<global::AI21.ToolDefinition>? tools = default,
            int? n = 1,
            int? maxTokens = 4096,
            double? temperature = default,
            double? topP = 1,
            global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = false,
            global::AI21.MockResponseConfig? mockResponse = default,
            global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? documents = default,
            global::AI21.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}