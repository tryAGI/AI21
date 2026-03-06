#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Wpp Feedback
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WppFeedbackSolutionsWppFeedbackPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}