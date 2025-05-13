#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Delete Demo<br/>
        /// Delete a demo.
        /// </summary>
        /// <param name="demoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDemoStudioV1DemosDemoIdDeleteAsync(
            string demoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}