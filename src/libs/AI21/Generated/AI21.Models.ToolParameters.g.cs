
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolParameters
    {
        /// <summary>
        /// Type of the parameter schema, only `object` is supported<br/>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ToolParametersTypeJsonConverter))]
        public global::AI21.ToolParametersType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Properties { get; set; }

        /// <summary>
        /// List of required properties
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameters" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the parameter schema, only `object` is supported<br/>
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required">
        /// List of required properties
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolParameters(
            object properties,
            global::AI21.ToolParametersType? type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Type = type;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameters" /> class.
        /// </summary>
        public ToolParameters()
        {
        }
    }
}