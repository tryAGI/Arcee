#nullable enable

namespace Arcee
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get daily usage statistics
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="modelProvider"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Arcee.UsageStats>> GetUsageStatsAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? model = default,
            string? modelProvider = default,
            string? source = default,
            int? limit = default,
            int? offset = default,
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}