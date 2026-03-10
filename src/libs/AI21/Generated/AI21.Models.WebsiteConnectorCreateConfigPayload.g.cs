
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsiteConnectorCreateConfigPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_linked_files")]
        public bool? ExtractLinkedFiles { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_dynamic_content")]
        public bool? WaitForDynamicContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_url_patterns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SkipUrlPatterns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_file_extensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetFileExtensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization")]
        public string? Localization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorCreateConfigPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="extractLinkedFiles">
        /// Default Value: false
        /// </param>
        /// <param name="waitForDynamicContent">
        /// Default Value: false
        /// </param>
        /// <param name="skipUrlPatterns"></param>
        /// <param name="targetFileExtensions"></param>
        /// <param name="localization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsiteConnectorCreateConfigPayload(
            string name,
            global::System.Collections.Generic.IList<string> skipUrlPatterns,
            global::System.Collections.Generic.IList<string> targetFileExtensions,
            bool? extractLinkedFiles,
            bool? waitForDynamicContent,
            string? localization)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SkipUrlPatterns = skipUrlPatterns ?? throw new global::System.ArgumentNullException(nameof(skipUrlPatterns));
            this.TargetFileExtensions = targetFileExtensions ?? throw new global::System.ArgumentNullException(nameof(targetFileExtensions));
            this.ExtractLinkedFiles = extractLinkedFiles;
            this.WaitForDynamicContent = waitForDynamicContent;
            this.Localization = localization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorCreateConfigPayload" /> class.
        /// </summary>
        public WebsiteConnectorCreateConfigPayload()
        {
        }
    }
}