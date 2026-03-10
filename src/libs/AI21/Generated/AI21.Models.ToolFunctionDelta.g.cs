
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolFunctionDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunctionDelta" /> class.
        /// </summary>
        /// <param name="arguments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolFunctionDelta(
            string arguments)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunctionDelta" /> class.
        /// </summary>
        public ToolFunctionDelta()
        {
        }
    }
}