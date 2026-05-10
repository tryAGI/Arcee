
#nullable enable

namespace Arcee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public long? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        public global::System.Collections.Generic.IList<string>? InputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string>? OutputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        public int? MaxOutputLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::System.Collections.Generic.Dictionary<string, string>? Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sampling_parameters")]
        public global::System.Collections.Generic.IList<string>? SupportedSamplingParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_features")]
        public global::System.Collections.Generic.IList<string>? SupportedFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelObject" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="huggingFaceId"></param>
        /// <param name="name"></param>
        /// <param name="created"></param>
        /// <param name="inputModalities"></param>
        /// <param name="outputModalities"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxOutputLength"></param>
        /// <param name="pricing"></param>
        /// <param name="supportedSamplingParameters"></param>
        /// <param name="supportedFeatures"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelObject(
            string? id,
            string? huggingFaceId,
            string? name,
            long? created,
            global::System.Collections.Generic.IList<string>? inputModalities,
            global::System.Collections.Generic.IList<string>? outputModalities,
            int? contextLength,
            int? maxOutputLength,
            global::System.Collections.Generic.Dictionary<string, string>? pricing,
            global::System.Collections.Generic.IList<string>? supportedSamplingParameters,
            global::System.Collections.Generic.IList<string>? supportedFeatures,
            string? description)
        {
            this.Id = id;
            this.HuggingFaceId = huggingFaceId;
            this.Name = name;
            this.Created = created;
            this.InputModalities = inputModalities;
            this.OutputModalities = outputModalities;
            this.ContextLength = contextLength;
            this.MaxOutputLength = maxOutputLength;
            this.Pricing = pricing;
            this.SupportedSamplingParameters = supportedSamplingParameters;
            this.SupportedFeatures = supportedFeatures;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelObject" /> class.
        /// </summary>
        public ModelObject()
        {
        }

    }
}