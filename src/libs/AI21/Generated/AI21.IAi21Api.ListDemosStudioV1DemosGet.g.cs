#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// List Demos<br/>
        /// List all available demos.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.Demo>> ListDemosStudioV1DemosGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}