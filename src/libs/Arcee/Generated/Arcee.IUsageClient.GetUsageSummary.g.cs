#nullable enable

namespace Arcee
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get usage summary
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.UsageSummary> GetUsageSummaryAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage summary
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.AutoSDKHttpResponse<global::Arcee.UsageSummary>> GetUsageSummaryAsResponseAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}