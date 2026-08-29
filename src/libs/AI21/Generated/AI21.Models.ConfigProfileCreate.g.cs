
#nullable enable

namespace AI21
{
    /// <summary>
    /// Body for ``POST /tokenwise/settings/configs``.
    /// </summary>
    public sealed partial class ConfigProfileCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigId { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigProfileCreate" /> class.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="overrides"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigProfileCreate(
            string configId,
            string? name,
            string? description,
            object? overrides,
            bool? enabled)
        {
            this.ConfigId = configId ?? throw new global::System.ArgumentNullException(nameof(configId));
            this.Name = name;
            this.Description = description;
            this.Overrides = overrides;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigProfileCreate" /> class.
        /// </summary>
        public ConfigProfileCreate()
        {
        }

    }
}