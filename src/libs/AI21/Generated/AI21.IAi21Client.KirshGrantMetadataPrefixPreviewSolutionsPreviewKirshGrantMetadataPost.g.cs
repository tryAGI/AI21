#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {

        /// <summary>
        /// Kirsh Grant Metadata Prefix Preview
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> KirshGrantMetadataPrefixPreviewSolutionsPreviewKirshGrantMetadataPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}