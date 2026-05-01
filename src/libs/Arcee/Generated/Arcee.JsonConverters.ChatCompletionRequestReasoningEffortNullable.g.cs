#nullable enable

namespace Arcee.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestReasoningEffortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Arcee.ChatCompletionRequestReasoningEffort?>
    {
        /// <inheritdoc />
        public override global::Arcee.ChatCompletionRequestReasoningEffort? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Arcee.ChatCompletionRequestReasoningEffortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Arcee.ChatCompletionRequestReasoningEffort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Arcee.ChatCompletionRequestReasoningEffort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Arcee.ChatCompletionRequestReasoningEffort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Arcee.ChatCompletionRequestReasoningEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
