
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePlanPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        public global::System.Collections.Generic.IList<object>? Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanPayload" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="schemas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePlanPayload(
            string code,
            global::System.Collections.Generic.IList<object>? schemas)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Schemas = schemas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanPayload" /> class.
        /// </summary>
        public CreatePlanPayload()
        {
        }
    }
}