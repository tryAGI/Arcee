
#nullable enable

namespace Arcee
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                ChatCompletionRequestReasoningEffort.High => "high",
                ChatCompletionRequestReasoningEffort.Low => "low",
                ChatCompletionRequestReasoningEffort.Medium => "medium",
                ChatCompletionRequestReasoningEffort.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatCompletionRequestReasoningEffort.High,
                "low" => ChatCompletionRequestReasoningEffort.Low,
                "medium" => ChatCompletionRequestReasoningEffort.Medium,
                "minimal" => ChatCompletionRequestReasoningEffort.Minimal,
                _ => null,
            };
        }
    }
}