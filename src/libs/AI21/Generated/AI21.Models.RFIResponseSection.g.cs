
#nullable enable

namespace AI21
{
    /// <summary>
    /// Model for a single RFI response section.
    /// </summary>
    public sealed partial class RFIResponseSection
    {
        /// <summary>
        /// Exact or closest RFI heading for the section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Header { get; set; }

        /// <summary>
        /// ≤350-character directive listing everything to include in that section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Generated content for this section based on company files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_content")]
        public string? GeneratedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RFIResponseSection" /> class.
        /// </summary>
        /// <param name="header">
        /// Exact or closest RFI heading for the section
        /// </param>
        /// <param name="description">
        /// ≤350-character directive listing everything to include in that section
        /// </param>
        /// <param name="generatedContent">
        /// Generated content for this section based on company files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RFIResponseSection(
            string header,
            string description,
            string? generatedContent)
        {
            this.Header = header ?? throw new global::System.ArgumentNullException(nameof(header));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.GeneratedContent = generatedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RFIResponseSection" /> class.
        /// </summary>
        public RFIResponseSection()
        {
        }
    }
}