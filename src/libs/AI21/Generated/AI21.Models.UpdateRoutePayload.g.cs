
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRoutePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<string>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRoutePayload" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="examples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRoutePayload(
            string description,
            global::System.Collections.Generic.IList<string>? examples)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRoutePayload" /> class.
        /// </summary>
        public UpdateRoutePayload()
        {
        }
    }
}