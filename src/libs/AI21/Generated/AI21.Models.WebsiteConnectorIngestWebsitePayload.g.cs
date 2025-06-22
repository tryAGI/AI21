
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsiteConnectorIngestWebsitePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sitemap_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SitemapUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_config")]
        public string? ClientConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorIngestWebsitePayload" /> class.
        /// </summary>
        /// <param name="sitemapUrl"></param>
        /// <param name="clientConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsiteConnectorIngestWebsitePayload(
            string sitemapUrl,
            string? clientConfig)
        {
            this.SitemapUrl = sitemapUrl ?? throw new global::System.ArgumentNullException(nameof(sitemapUrl));
            this.ClientConfig = clientConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorIngestWebsitePayload" /> class.
        /// </summary>
        public WebsiteConnectorIngestWebsitePayload()
        {
        }
    }
}