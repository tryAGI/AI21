
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.RoleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.RoleType Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishReason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.FinishReason FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutput" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="role">
        /// An enumeration.
        /// </param>
        /// <param name="finishReason"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatOutput(
            string text,
            global::AI21.RoleType role,
            global::AI21.FinishReason finishReason)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Role = role;
            this.FinishReason = finishReason ?? throw new global::System.ArgumentNullException(nameof(finishReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutput" /> class.
        /// </summary>
        public ChatOutput()
        {
        }
    }
}