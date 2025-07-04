
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequirementsGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.RequirementItem> Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementsGenerationResponse" /> class.
        /// </summary>
        /// <param name="requirements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequirementsGenerationResponse(
            global::System.Collections.Generic.IList<global::AI21.RequirementItem> requirements)
        {
            this.Requirements = requirements ?? throw new global::System.ArgumentNullException(nameof(requirements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementsGenerationResponse" /> class.
        /// </summary>
        public RequirementsGenerationResponse()
        {
        }
    }
}