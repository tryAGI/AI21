#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AI21.JsonConverters
{
    /// <inheritdoc />
    public class MessagesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AI21.MessagesItem>
    {
        /// <inheritdoc />
        public override global::AI21.MessagesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AI21.UserMessage? userMessage = default;
            if (discriminator?.Role == global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.UserMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AI21.AssistantMessage? assistantMessage = default;
            if (discriminator?.Role == global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.AssistantMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AI21.ToolMessage? toolMessage = default;
            if (discriminator?.Role == global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.ToolMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AI21.SystemMessage? systemMessage = default;
            if (discriminator?.Role == global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.SystemMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::AI21.MessagesItem(
                discriminator?.Role,
                userMessage,
                assistantMessage,
                toolMessage,
                systemMessage
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AI21.MessagesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeInfo);
            }
            else if (value.IsToolMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolMessage, typeInfo);
            }
            else if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeInfo);
            }
        }
    }
}