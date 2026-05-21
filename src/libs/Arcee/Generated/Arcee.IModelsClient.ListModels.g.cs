#nullable enable

namespace Arcee
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.ModelListResponse> ListModelsAsync(
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List models
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.AutoSDKHttpResponse<global::Arcee.ModelListResponse>> ListModelsAsResponseAsync(
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}