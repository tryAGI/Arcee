#nullable enable

namespace Arcee
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.ChatCompletionResponse> CreateChatCompletionAsync(

            global::Arcee.ChatCompletionRequest request,
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Arcee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.AutoSDKHttpResponse<global::Arcee.ChatCompletionResponse>> CreateChatCompletionAsResponseAsync(

            global::Arcee.ChatCompletionRequest request,
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="stream"></param>
        /// <param name="stop"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Arcee.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::Arcee.Message> messages,
            int? maxTokens = default,
            int? maxCompletionTokens = default,
            float? temperature = default,
            float? topP = default,
            int? n = default,
            bool? stream = default,
            global::Arcee.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            float? presencePenalty = default,
            float? frequencyPenalty = default,
            global::System.Collections.Generic.IList<global::Arcee.Tool>? tools = default,
            string? toolChoice = default,
            global::Arcee.ResponseFormat? responseFormat = default,
            global::Arcee.ChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::Arcee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}