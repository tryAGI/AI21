
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.OrganizationModelResponse> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationModelsResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationModelsResponse(
            global::System.Collections.Generic.IList<global::AI21.OrganizationModelResponse> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationModelsResponse" /> class.
        /// </summary>
        public OrganizationModelsResponse()
        {
        }
    }
}