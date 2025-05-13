#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Demo<br/>
        /// Get a specific demo by ID.
        /// </summary>
        /// <param name="demoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Demo> GetDemoStudioV1DemosDemoIdGetAsync(
            string demoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}