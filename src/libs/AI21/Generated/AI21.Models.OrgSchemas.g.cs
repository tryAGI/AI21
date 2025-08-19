
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgSchemas
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.OrgSchema> Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSchemas" /> class.
        /// </summary>
        /// <param name="schemas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgSchemas(
            global::System.Collections.Generic.IList<global::AI21.OrgSchema> schemas)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSchemas" /> class.
        /// </summary>
        public OrgSchemas()
        {
        }
    }
}