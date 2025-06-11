#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Process Rfi Document
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.RFIResponseSection>> ProcessRfiDocumentStudioV1DemosRfiProcessRfiPostAsync(
            global::AI21.BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Process Rfi Document
        /// </summary>
        /// <param name="file">
        /// RFI document file (PDF supported)
        /// </param>
        /// <param name="filename">
        /// RFI document file (PDF supported)
        /// </param>
        /// <param name="budget">
        /// Budget level: LOW, MEDIUM, or HIGH<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="vectorStoreId">
        /// Vector store ID to use for RFI processing
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.RFIResponseSection>> ProcessRfiDocumentStudioV1DemosRfiProcessRfiPostAsync(
            byte[] file,
            string filename,
            string? budget = default,
            string? vectorStoreId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}