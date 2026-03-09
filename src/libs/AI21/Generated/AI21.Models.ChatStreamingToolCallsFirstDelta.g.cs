
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamingToolCallsFirstDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart> ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamingToolCallsFirstDelta" /> class.
        /// </summary>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamingToolCallsFirstDelta(
            global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart> toolCalls)
        {
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamingToolCallsFirstDelta" /> class.
        /// </summary>
        public ChatStreamingToolCallsFirstDelta()
        {
        }
    }
}