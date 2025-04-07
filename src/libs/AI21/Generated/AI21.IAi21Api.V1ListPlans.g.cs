#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// List Plans
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ListPlansResponse> V1ListPlansAsync(
            string assistantId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}