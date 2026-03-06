
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchToolResource
    {
        /// <summary>
        /// Default Value: web_search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.WebSearchToolResourceTypeJsonConverter))]
        public global::AI21.WebSearchToolResourceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_to_web")]
        public bool? FallbackToWeb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suffix")]
        public string? QuerySuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rephrase_query")]
        public bool? RephraseQuery { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cached_pages")]
        public bool? UseCachedPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolResource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: web_search
        /// </param>
        /// <param name="urls"></param>
        /// <param name="fallbackToWeb"></param>
        /// <param name="querySuffix"></param>
        /// <param name="rephraseQuery"></param>
        /// <param name="useCachedPages">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolResource(
            global::AI21.WebSearchToolResourceType? type,
            global::System.Collections.Generic.IList<string>? urls,
            bool? fallbackToWeb,
            string? querySuffix,
            bool? rephraseQuery,
            bool? useCachedPages)
        {
            this.Type = type;
            this.Urls = urls;
            this.FallbackToWeb = fallbackToWeb;
            this.QuerySuffix = querySuffix;
            this.RephraseQuery = rephraseQuery;
            this.UseCachedPages = useCachedPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolResource" /> class.
        /// </summary>
        public WebSearchToolResource()
        {
        }
    }
}