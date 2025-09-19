#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Run Assistant
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> V1RunAssistantAsync(
            string assistantId,
            global::AI21.RunAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run Assistant
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="input"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="outputType"></param>
        /// <param name="include">
        /// Default Value: [data_sources, requirements_result, requirements_result.metadata]
        /// </param>
        /// <param name="structuredRagEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="dynamicPlanningEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="responseLanguage">
        /// Default Value: unset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> V1RunAssistantAsync(
            string assistantId,
            global::System.Collections.Generic.IList<global::AI21.Message> input,
            bool? verbose = default,
            object? outputType = default,
            global::System.Collections.Generic.IList<string>? include = default,
            bool? structuredRagEnabled = default,
            bool? dynamicPlanningEnabled = default,
            global::AI21.RunAssistantRequestResponseLanguage? responseLanguage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}