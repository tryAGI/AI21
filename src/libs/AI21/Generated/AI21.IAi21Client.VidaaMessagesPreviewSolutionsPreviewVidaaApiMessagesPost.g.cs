#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {

        /// <summary>
        /// Vidaa Messages Preview
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VidaaMessagesPreviewSolutionsPreviewVidaaApiMessagesPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}