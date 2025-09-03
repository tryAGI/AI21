
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorConnectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_updated")]
        public global::System.DateTime? LatestUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_indexed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FilesIndexed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationDate { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ParagonSyncStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.ParagonSyncStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public string? LastSyncedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorConnectionStatus" /> class.
        /// </summary>
        /// <param name="latestUpdated"></param>
        /// <param name="filesIndexed"></param>
        /// <param name="creationDate"></param>
        /// <param name="status">
        /// An enumeration.
        /// </param>
        /// <param name="lastSyncedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorConnectionStatus(
            int filesIndexed,
            global::System.DateTime creationDate,
            global::AI21.ParagonSyncStatus status,
            global::System.DateTime? latestUpdated,
            string? lastSyncedAt)
        {
            this.FilesIndexed = filesIndexed;
            this.CreationDate = creationDate;
            this.Status = status;
            this.LatestUpdated = latestUpdated;
            this.LastSyncedAt = lastSyncedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorConnectionStatus" /> class.
        /// </summary>
        public ConnectorConnectionStatus()
        {
        }
    }
}