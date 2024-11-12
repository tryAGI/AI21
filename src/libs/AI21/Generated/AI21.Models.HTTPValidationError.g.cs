
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTTPValidationError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::System.Collections.Generic.IList<global::AI21.ValidationError>? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        /// <param name="detail"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public HTTPValidationError(
            global::System.Collections.Generic.IList<global::AI21.ValidationError>? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        public HTTPValidationError()
        {
        }
    }
}