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
        global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> CreateMaestroRunStudioV1MaestroRunsPostAsync(
            global::AI21.CreateMaestroRunsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Maestro Run
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="outputType"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="context"></param>
        /// <param name="constraints"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> CreateMaestroRunStudioV1MaestroRunsPostAsync(
            global::System.Collections.Generic.IList<global::AI21.Message> messages,
            object? outputType = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>>? tools = default,
            global::AI21.ToolResources? toolResources = default,
            bool? verbose = default,
            object? context = default,
            global::System.Collections.Generic.IList<global::AI21.Constraint>? constraints = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}