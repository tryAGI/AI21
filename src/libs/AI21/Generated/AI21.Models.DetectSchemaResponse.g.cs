
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectSchemaResponse
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectSchemaResponse" /> class.
        /// </summary>
        /// <param name="schemaName"></param>
        /// <param name="schemaDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectSchemaResponse(
            string schemaName,
            object schemaDefinition)
        {
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.SchemaDefinition = schemaDefinition ?? throw new global::System.ArgumentNullException(nameof(schemaDefinition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectSchemaResponse" /> class.
        /// </summary>
        public DetectSchemaResponse()
        {
        }
    }
}