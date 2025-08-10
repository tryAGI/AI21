
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorsSyncParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_name")]
        public string? ConfigurationName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsSyncParams" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="dataSource"></param>
        /// <param name="organizationId"></param>
        /// <param name="pipeline"></param>
        /// <param name="configuration"></param>
        /// <param name="configurationName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorsSyncParams(
            string token,
            string dataSource,
            string organizationId,
            string pipeline,
            object? configuration,
            string? configurationName)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.DataSource = dataSource ?? throw new global::System.ArgumentNullException(nameof(dataSource));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Pipeline = pipeline ?? throw new global::System.ArgumentNullException(nameof(pipeline));
            this.Configuration = configuration;
            this.ConfigurationName = configurationName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsSyncParams" /> class.
        /// </summary>
        public ConnectorsSyncParams()
        {
        }
    }
}