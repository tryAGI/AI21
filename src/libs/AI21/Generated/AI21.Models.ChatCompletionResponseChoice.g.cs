
#nullable enable

namespace AI21
{
    /// <summary>
    /// A single possible response generated by the system. For non-streaming replies, There<br/>
    /// can be multiple responses, depending on what `n` value you specified in the request.
    /// </summary>
    public sealed partial class ChatCompletionResponseChoice
    {
        /// <summary>
        /// Zero-based index of the message in the list of messages. Note that this might not<br/>
        /// correspond with the position in the response list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.AssistantMessage Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::AI21.Logprobs? Logprobs { get; set; }

        /// <summary>
        /// Why the message ended. Possible reasons:<br/>
        ///   - `stop`: The response ended naturally as a complete answer (due to<br/>
        ///     [end-of-sequence token](https://huggingface.co/docs/transformers/v4.32.1/en/llm_tutorial#generate-text))<br/>
        ///     or because the model generated a stop sequence provided in the request.<br/>
        ///   - `length`:  The response ended by reaching `max_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the message in the list of messages. Note that this might not<br/>
        /// correspond with the position in the response list.
        /// </param>
        /// <param name="message"></param>
        /// <param name="logprobs"></param>
        /// <param name="finishReason">
        /// Why the message ended. Possible reasons:<br/>
        ///   - `stop`: The response ended naturally as a complete answer (due to<br/>
        ///     [end-of-sequence token](https://huggingface.co/docs/transformers/v4.32.1/en/llm_tutorial#generate-text))<br/>
        ///     or because the model generated a stop sequence provided in the request.<br/>
        ///   - `length`:  The response ended by reaching `max_tokens`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionResponseChoice(
            int index,
            global::AI21.AssistantMessage message,
            global::AI21.Logprobs? logprobs,
            string? finishReason)
        {
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Logprobs = logprobs;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        public ChatCompletionResponseChoice()
        {
        }
    }
}