
#nullable enable

namespace Arcee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        public int? TotalInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        public int? TotalOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        public int? TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_users")]
        public int? UniqueUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_models")]
        public int? UniqueModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_providers")]
        public int? UniqueProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_usage")]
        public int? ApiUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_usage")]
        public int? AppUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_range_days")]
        public int? DateRangeDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummary" /> class.
        /// </summary>
        /// <param name="totalInputTokens"></param>
        /// <param name="totalOutputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="totalRequests"></param>
        /// <param name="uniqueUsers"></param>
        /// <param name="uniqueModels"></param>
        /// <param name="uniqueProviders"></param>
        /// <param name="apiUsage"></param>
        /// <param name="appUsage"></param>
        /// <param name="dateRangeDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageSummary(
            int? totalInputTokens,
            int? totalOutputTokens,
            int? totalTokens,
            int? totalRequests,
            int? uniqueUsers,
            int? uniqueModels,
            int? uniqueProviders,
            int? apiUsage,
            int? appUsage,
            int? dateRangeDays)
        {
            this.TotalInputTokens = totalInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.TotalTokens = totalTokens;
            this.TotalRequests = totalRequests;
            this.UniqueUsers = uniqueUsers;
            this.UniqueModels = uniqueModels;
            this.UniqueProviders = uniqueProviders;
            this.ApiUsage = apiUsage;
            this.AppUsage = appUsage;
            this.DateRangeDays = dateRangeDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummary" /> class.
        /// </summary>
        public UsageSummary()
        {
        }
    }
}