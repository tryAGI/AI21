
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationSchemaRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object SchemaObject { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_classification")]
        public bool? RunClassification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationSchemaRequest" /> class.
        /// </summary>
        /// <param name="schemaName"></param>
        /// <param name="schemaObject"></param>
        /// <param name="runClassification">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationSchemaRequest(
            string schemaName,
            object schemaObject,
            bool? runClassification)
        {
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.SchemaObject = schemaObject ?? throw new global::System.ArgumentNullException(nameof(schemaObject));
            this.RunClassification = runClassification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationSchemaRequest" /> class.
        /// </summary>
        public CreateOrganizationSchemaRequest()
        {
        }
    }
}