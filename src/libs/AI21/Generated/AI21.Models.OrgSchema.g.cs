
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object SchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object TableStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSchema" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="schemaName"></param>
        /// <param name="schemaDefinition"></param>
        /// <param name="tableStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgSchema(
            global::System.Guid organizationId,
            string schemaName,
            object schemaDefinition,
            object tableStats)
        {
            this.OrganizationId = organizationId;
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.SchemaDefinition = schemaDefinition ?? throw new global::System.ArgumentNullException(nameof(schemaDefinition));
            this.TableStats = tableStats ?? throw new global::System.ArgumentNullException(nameof(tableStats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSchema" /> class.
        /// </summary>
        public OrgSchema()
        {
        }
    }
}