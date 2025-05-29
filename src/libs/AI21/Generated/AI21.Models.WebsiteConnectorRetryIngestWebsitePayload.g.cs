
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsiteConnectorRetryIngestWebsitePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WebsiteId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorRetryIngestWebsitePayload" /> class.
        /// </summary>
        /// <param name="websiteId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsiteConnectorRetryIngestWebsitePayload(
            global::System.Guid websiteId)
        {
            this.WebsiteId = websiteId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteConnectorRetryIngestWebsitePayload" /> class.
        /// </summary>
        public WebsiteConnectorRetryIngestWebsitePayload()
        {
        }
    }
}