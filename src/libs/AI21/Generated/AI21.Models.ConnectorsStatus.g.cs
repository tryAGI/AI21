
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::AI21.ConnectorsWorkflowStatus WorkflowStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_successfully_uploaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int FilesSuccessfullyUploaded { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_uploaded_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int FailedUploadedFiles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsStatus" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="workflowStatus">
        /// An enumeration.
        /// </param>
        /// <param name="filesSuccessfullyUploaded"></param>
        /// <param name="failedUploadedFiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorsStatus(
            string createdAt,
            global::AI21.ConnectorsWorkflowStatus workflowStatus,
            int filesSuccessfullyUploaded,
            int failedUploadedFiles)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.WorkflowStatus = workflowStatus;
            this.FilesSuccessfullyUploaded = filesSuccessfullyUploaded;
            this.FailedUploadedFiles = failedUploadedFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsStatus" /> class.
        /// </summary>
        public ConnectorsStatus()
        {
        }
    }
}