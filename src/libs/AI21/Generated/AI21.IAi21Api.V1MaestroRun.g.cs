#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Create Maestro Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> V1MaestroRunAsync(
            global::AI21.CreateMaestroRunsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Maestro Run
        /// </summary>
        /// <param name="input"></param>
        /// <param name="outputType"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="context"></param>
        /// <param name="requirements"></param>
        /// <param name="budget"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="include"></param>
        /// <param name="structuredRagEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="toolsAllowed">
        /// Default Value: false
        /// </param>
        /// <param name="payloadType">
        /// Default Value: maestro_run
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> V1MaestroRunAsync(
            global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string> input,
            object? outputType = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>>? tools = default,
            global::AI21.ToolResources? toolResources = default,
            object? context = default,
            global::System.Collections.Generic.IList<global::AI21.Requirement>? requirements = default,
            global::AI21.CreateMaestroRunsPayloadBudget? budget = default,
            bool? verbose = default,
            global::System.Collections.Generic.IList<global::AI21.OutputOptions>? include = default,
            bool? structuredRagEnabled = default,
            bool? toolsAllowed = default,
            global::AI21.MaestroPayloadType? payloadType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}