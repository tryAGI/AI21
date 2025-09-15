
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTTPToolFunctionParameters
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.HTTPToolFunctionParametersTypeJsonConverter))]
        public global::AI21.HTTPToolFunctionParametersType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::AI21.HTTPToolFunctionParamProperties> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Required { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPToolFunctionParameters" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        /// <param name="additionalProperties">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPToolFunctionParameters(
            global::System.Collections.Generic.Dictionary<string, global::AI21.HTTPToolFunctionParamProperties> properties,
            global::System.Collections.Generic.IList<string> required,
            global::AI21.HTTPToolFunctionParametersType? type,
            bool? additionalProperties)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required ?? throw new global::System.ArgumentNullException(nameof(required));
            this.Type = type;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPToolFunctionParameters" /> class.
        /// </summary>
        public HTTPToolFunctionParameters()
        {
        }
    }
}