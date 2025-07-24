
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyV1LibraryUpload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_configs")]
        public string? CustomConfigs { get; set; }

        /// <summary>
        /// Default Value: immediate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.UploadModeJsonConverter))]
        public global::AI21.UploadMode? UploadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public global::System.Guid? BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        public string? DataSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyV1LibraryUpload" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="publicUrl"></param>
        /// <param name="customConfigs"></param>
        /// <param name="uploadMode">
        /// Default Value: immediate
        /// </param>
        /// <param name="batchId"></param>
        /// <param name="dataSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyV1LibraryUpload(
            byte[] file,
            string filename,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            string? publicUrl,
            string? customConfigs,
            global::AI21.UploadMode? uploadMode,
            global::System.Guid? batchId,
            string? dataSource)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Path = path;
            this.Labels = labels;
            this.PublicUrl = publicUrl;
            this.CustomConfigs = customConfigs;
            this.UploadMode = uploadMode;
            this.BatchId = batchId;
            this.DataSource = dataSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyV1LibraryUpload" /> class.
        /// </summary>
        public BodyV1LibraryUpload()
        {
        }
    }
}