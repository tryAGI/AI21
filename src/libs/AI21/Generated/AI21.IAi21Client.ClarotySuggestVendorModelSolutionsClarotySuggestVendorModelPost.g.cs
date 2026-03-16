#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Claroty Suggest Vendor Model
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ClarotySuggestVendorModelSolutionsClarotySuggestVendorModelPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}