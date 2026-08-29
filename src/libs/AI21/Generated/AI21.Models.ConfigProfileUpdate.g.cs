
#nullable enable

namespace AI21
{
    /// <summary>
    /// Body for ``PUT /tokenwise/settings/configs/{config_id}`` — partial update.<br/>
    /// An explicit ``overrides: null`` is "leave unchanged"; ``{}`` clears them.<br/>
    /// The gateway enforces the same semantics; we forward the JSON verbatim.
    /// </summary>
    public sealed partial class ConfigProfileUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public object? Overrides { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigProfileUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="overrides"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigProfileUpdate(
            string? name,
            string? description,
            object? overrides,
            bool? enabled)
        {
            this.Name = name;
            this.Description = description;
            this.Overrides = overrides;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigProfileUpdate" /> class.
        /// </summary>
        public ConfigProfileUpdate()
        {
        }

    }
}