#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Get Custom Models List
        /// </summary>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1GetCustomModelsAsync(
            bool? includeMetadata = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}