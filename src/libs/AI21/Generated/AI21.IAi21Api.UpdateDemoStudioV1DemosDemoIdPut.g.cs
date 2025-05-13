#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Update Demo<br/>
        /// Update an existing demo.
        /// </summary>
        /// <param name="demoId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Demo> UpdateDemoStudioV1DemosDemoIdPutAsync(
            string demoId,
            global::AI21.DemoUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Demo<br/>
        /// Update an existing demo.
        /// </summary>
        /// <param name="demoId"></param>
        /// <param name="name">
        /// Name of the demo
        /// </param>
        /// <param name="visibility">
        /// Visibility of the demo (public/private)
        /// </param>
        /// <param name="status">
        /// Status of the demo (active/inactive)
        /// </param>
        /// <param name="config">
        /// Demo configuration
        /// </param>
        /// <param name="uiComponentName">
        /// Name of the UI component
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Demo> UpdateDemoStudioV1DemosDemoIdPutAsync(
            string demoId,
            string? name = default,
            global::AI21.DemoVisibility? visibility = default,
            global::AI21.DemoStatus? status = default,
            object? config = default,
            string? uiComponentName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}