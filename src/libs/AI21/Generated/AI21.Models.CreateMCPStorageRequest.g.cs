
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMCPStorageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AuthenticationTypeJsonConverter))]
        public global::AI21.AuthenticationType? AuthenticationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_header_name")]
        public string? AuthHeaderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_value")]
        public string? AuthValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPStorageRequest" /> class.
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="serverLabel"></param>
        /// <param name="workspaceId"></param>
        /// <param name="authenticationType">
        /// An enumeration.
        /// </param>
        /// <param name="authHeaderName"></param>
        /// <param name="authValue"></param>
        /// <param name="allowedTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMCPStorageRequest(
            string serverUrl,
            string serverLabel,
            global::System.Guid? workspaceId,
            global::AI21.AuthenticationType? authenticationType,
            string? authHeaderName,
            string? authValue,
            global::System.Collections.Generic.IList<string>? allowedTools)
        {
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.WorkspaceId = workspaceId;
            this.AuthenticationType = authenticationType;
            this.AuthHeaderName = authHeaderName;
            this.AuthValue = authValue;
            this.AllowedTools = allowedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPStorageRequest" /> class.
        /// </summary>
        public CreateMCPStorageRequest()
        {
        }
    }
}