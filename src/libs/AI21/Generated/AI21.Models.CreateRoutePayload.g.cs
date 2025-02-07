
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRoutePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoutePayload" /> class.
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="examples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRoutePayload(
            string planId,
            string name,
            string description,
            global::System.Collections.Generic.IList<string> examples)
        {
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoutePayload" /> class.
        /// </summary>
        public CreateRoutePayload()
        {
        }
    }
}