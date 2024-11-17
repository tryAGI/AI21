
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.ModelName Model { get; set; }

        /// <summary>
        /// The previous messages in this chat, from oldest (index 0) to newest. Messages<br/>
        /// must be alternating `user`/`assistant` messages, optionally starting with a `system`<br/>
        /// message. For single turn interactions, this should be an optional `system` message,<br/>
        /// and a single `user` message. Maximum total size for the list is about 256K tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.MessagesItem> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::AI21.ToolDefinition>? Tools { get; set; }

        /// <summary>
        /// How many chat responses to generate. _Range: 1 – 16_ **Notes:**<br/>
        /// - If `n &gt; 1`, setting `temperature=0` will fail because all answers are guaranteed to be duplicates.<br/>
        /// - `n` must be 1 when `stream = True`<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// The maximum number of tokens to allow for each generated response message. Typically<br/>
        /// the best way to limit output length is by providing a length limit in the system<br/>
        /// prompt (for example, "limit your answers to three sentences"). _Range: 0 – 4096_<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// How much variation to provide in each answer. Setting this value to 0 guarantees the<br/>
        /// same response to the same question every time. Setting a higher value encourages more<br/>
        /// variation. Modifies the distribution from which tokens are sampled.<br/>
        /// [More information](https://docs.ai21.com/docs/sampling-from-language-models#temperature)<br/>
        /// _Range: 0.0 – 2.0_
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Limit the pool of next tokens in each step to the top N percentile of possible<br/>
        /// tokens, where 1.0 means the pool of all possible tokens, and 0.01 means the<br/>
        /// pool of only the most likely next tokens. [More information]<br/>
        /// (https://docs.ai21.com/docs/sampling-from-language-models#topp) _Range: 0 \&lt;= value \&lt;=1.0_<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// End the message when the model generates one of these strings. The stop sequence<br/>
        /// is not included in the generated message. Each sequence can be up to 64K long, and<br/>
        /// can contain newlines as `\n` characters. Examples:<br/>
        /// - Single stop string with a word and a period: "monkeys."<br/>
        /// - Multiple stop strings and a newline: ["cat", "dog", " .", "####", "\n"]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Whether or not to stream the result one token at a time using<br/>
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).<br/>
        /// This can be useful when waiting for long results where a long wait time for an<br/>
        /// answer can be problematic, such as a chatbot. If set to `True`, then `n` must<br/>
        /// be 1. A streaming response is different than the non-streaming response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock_response")]
        public global::AI21.MockResponseConfig? MockResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::AI21.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatRequest(
            global::AI21.ModelName model,
            global::System.Collections.Generic.IList<global::AI21.MessagesItem> messages,
            global::System.Collections.Generic.IList<global::AI21.ToolDefinition>? tools,
            int? n,
            int? maxTokens,
            double? temperature,
            double? topP,
            global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            global::AI21.MockResponseConfig? mockResponse,
            global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? documents,
            global::AI21.ResponseFormat? responseFormat)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
            this.N = n;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Stop = stop;
            this.Stream = stream;
            this.MockResponse = mockResponse;
            this.Documents = documents;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        public ChatRequest()
        {
        }
    }
}