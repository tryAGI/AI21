
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost" /> class.
        /// </summary>
        public BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost()
        {
        }
    }
}