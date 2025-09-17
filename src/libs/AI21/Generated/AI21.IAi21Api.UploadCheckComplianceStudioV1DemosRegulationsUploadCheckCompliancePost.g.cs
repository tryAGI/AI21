#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Upload Check Compliance<br/>
        /// Check compliance of a document file against regulatory requirements.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePostAsync(
            global::AI21.BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Check Compliance<br/>
        /// Check compliance of a document file against regulatory requirements.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="budget">
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="vectorStoreId">
        /// Vector store ID to use for RFI processing
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePostAsync(
            byte[] file,
            string filename,
            string? budget = default,
            string? vectorStoreId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}