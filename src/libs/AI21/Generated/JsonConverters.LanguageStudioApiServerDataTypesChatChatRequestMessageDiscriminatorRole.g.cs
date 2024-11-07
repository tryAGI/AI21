#nullable enable

namespace AI21.JsonConverters
{
    /// <inheritdoc />
    public sealed class LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole>
    {
        /// <inheritdoc />
        public override global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole Read(
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
                        return global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleExtensions.ToValueString(value));
        }
    }
}