#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Compare Text<br/>
        /// Compare text in a document file against a reference text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CompareTextStudioV1DemosDocumentModifierCompareTextPostAsync(
            global::AI21.CompareTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Compare Text<br/>
        /// Compare text in a document file against a reference text.
        /// </summary>
        /// <param name="originalText"></param>
        /// <param name="modifiedText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CompareTextStudioV1DemosDocumentModifierCompareTextPostAsync(
            string originalText,
            string modifiedText,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}