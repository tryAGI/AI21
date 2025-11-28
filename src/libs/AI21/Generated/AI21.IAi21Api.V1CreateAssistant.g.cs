#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Create Assistant
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Assistant> V1CreateAssistantAsync(
            global::AI21.CreateAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Assistant
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="optimization"></param>
        /// <param name="avatar"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="requirements"></param>
        /// <param name="budget">
        /// Default Value: medium
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Assistant> V1CreateAssistantAsync(
            string name,
            string? description = default,
            string? optimization = default,
            string? avatar = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.AssistantTool2>>? tools = default,
            object? toolResources = default,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? requirements = default,
            global::AI21.BudgetLevel? budget = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}