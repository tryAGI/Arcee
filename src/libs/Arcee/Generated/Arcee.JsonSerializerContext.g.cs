
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Arcee
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Arcee.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Arcee.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter),

            typeof(global::Arcee.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Arcee.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Arcee.ContentPart>>),

            typeof(global::Arcee.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ChatCompletionRequestReasoningEffort), TypeInfoPropertyName = "ChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.OneOf<string, global::System.Collections.Generic.IList<global::Arcee.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.ModelObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.UsageStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.UsageSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Arcee.UsageStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Arcee.OneOf<string, global::System.Collections.Generic.List<global::Arcee.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Arcee.UsageStats>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}