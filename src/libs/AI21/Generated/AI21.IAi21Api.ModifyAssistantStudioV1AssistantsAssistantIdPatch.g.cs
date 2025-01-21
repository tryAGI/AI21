#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Modify Assistant
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Assistant> ModifyAssistantStudioV1AssistantsAssistantIdPatchAsync(
            string assistantId,
            global::AI21.ModifyAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify Assistant
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="optimization">
        /// An enumeration.
        /// </param>
        /// <param name="avatar"></param>
        /// <param name="isArchived">
        /// Default Value: false
        /// </param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Assistant> ModifyAssistantStudioV1AssistantsAssistantIdPatchAsync(
            string assistantId,
            string? name = default,
            string? description = default,
            global::AI21.RunOptimization? optimization = default,
            string? avatar = default,
            bool? isArchived = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::AI21.AssistantTool>? tools = default,
            global::AI21.AssistantToolResource? toolResources = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}