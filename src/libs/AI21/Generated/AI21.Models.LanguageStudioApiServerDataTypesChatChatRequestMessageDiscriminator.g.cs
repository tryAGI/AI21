
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleJsonConverter))]
        public global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator(
            global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator" /> class.
        /// </summary>
        public LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator()
        {
        }
    }
}