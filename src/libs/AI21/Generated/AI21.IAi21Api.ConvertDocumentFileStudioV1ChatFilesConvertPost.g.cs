#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Convert Document File
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730899065206
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
            global::AI21.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Convert Document File
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730899065206
        /// </param>
        /// <param name="files"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}