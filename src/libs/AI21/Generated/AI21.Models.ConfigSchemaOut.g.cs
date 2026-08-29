
#nullable enable

namespace AI21
{
    /// <summary>
    /// Response shape for ``GET /tokenwise/settings/configs/schema``.<br/>
    /// Loosely typed — the gateway derives this from its ``ProxySettings`` and the<br/>
    /// shape evolves with new transformer groups. Kept as a flexible envelope so<br/>
    /// api-server does not need a release every time the gateway adds a knob.
    /// </summary>
    public sealed partial class ConfigSchemaOut
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSchemaOut" /> class.
        /// </summary>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigSchemaOut(
            global::System.Collections.Generic.IList<object> groups)
        {
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSchemaOut" /> class.
        /// </summary>
        public ConfigSchemaOut()
        {
        }

    }
}