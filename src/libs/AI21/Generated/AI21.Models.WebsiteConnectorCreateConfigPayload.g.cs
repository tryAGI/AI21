
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
        [global::System.Text.Json.Serialization.JsonPropertyName("get_files_from_sitemap")]
        public bool? GetFilesFromSitemap { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_slow_domain")]
        public bool? IsSlowDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_patterns_to_exclude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UrlPatternsToExclude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_extensions_to_keep")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UrlExtensionsToKeep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorCreateConfigPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="getFilesFromSitemap">
        /// Default Value: false
        /// </param>
        /// <param name="isSlowDomain">
        /// Default Value: false
        /// </param>
        /// <param name="urlPatternsToExclude"></param>
        /// <param name="urlExtensionsToKeep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsiteConnectorCreateConfigPayload(
            string name,
            global::System.Collections.Generic.IList<string> urlPatternsToExclude,
            global::System.Collections.Generic.IList<string> urlExtensionsToKeep,
            bool? getFilesFromSitemap,
            bool? isSlowDomain)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UrlPatternsToExclude = urlPatternsToExclude ?? throw new global::System.ArgumentNullException(nameof(urlPatternsToExclude));
            this.UrlExtensionsToKeep = urlExtensionsToKeep ?? throw new global::System.ArgumentNullException(nameof(urlExtensionsToKeep));
            this.GetFilesFromSitemap = getFilesFromSitemap;
            this.IsSlowDomain = isSlowDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorCreateConfigPayload" /> class.
        /// </summary>
        public WebsiteConnectorCreateConfigPayload()
        {
        }
    }
}