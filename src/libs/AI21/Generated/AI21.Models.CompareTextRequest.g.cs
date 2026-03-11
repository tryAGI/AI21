
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompareTextRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompareTextRequest" /> class.
        /// </summary>
        /// <param name="originalText"></param>
        /// <param name="modifiedText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompareTextRequest(
            string originalText,
            string modifiedText)
        {
            this.OriginalText = originalText ?? throw new global::System.ArgumentNullException(nameof(originalText));
            this.ModifiedText = modifiedText ?? throw new global::System.ArgumentNullException(nameof(modifiedText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompareTextRequest" /> class.
        /// </summary>
        public CompareTextRequest()
        {
        }
    }
}