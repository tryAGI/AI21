#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Create Stateless Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.StatelessRunResult> CreateStatelessRunStudioV1StatelessRunPostAsync(
            global::AI21.CreateStatelessRunsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Stateless Run
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.StatelessRunResult> CreateStatelessRunStudioV1StatelessRunPostAsync(
            global::System.Collections.Generic.IList<string> messages,
            string? outputType = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            global::AI21.AssistantToolResource? toolResources = default,
            bool? verbose = default,
            object? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}