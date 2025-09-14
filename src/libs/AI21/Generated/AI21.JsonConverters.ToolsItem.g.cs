#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AI21.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AI21.ToolsItem>
    {
        /// <inheritdoc />
        public override global::AI21.ToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.CreateMaestroRunsPayloadToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.CreateMaestroRunsPayloadToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.CreateMaestroRunsPayloadToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AI21.HTTPToolResource? http = default;
            if (discriminator?.Type == global::AI21.CreateMaestroRunsPayloadToolDiscriminatorType.Http)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.HTTPToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.HTTPToolResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.HTTPToolResource)}");
                http = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AI21.MCPToolResource? mcp = default;
            if (discriminator?.Type == global::AI21.CreateMaestroRunsPayloadToolDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.MCPToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.MCPToolResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.MCPToolResource)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AI21.FileSearchToolResource? fileSearch = default;
            if (discriminator?.Type == global::AI21.CreateMaestroRunsPayloadToolDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.FileSearchToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.FileSearchToolResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.FileSearchToolResource)}");
                fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AI21.WebSearchToolResource? webSearch = default;
            if (discriminator?.Type == global::AI21.CreateMaestroRunsPayloadToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.WebSearchToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.WebSearchToolResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AI21.WebSearchToolResource)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::AI21.ToolsItem(
                discriminator?.Type,
                http,
                mcp,
                fileSearch,
                webSearch
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AI21.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.HTTPToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.HTTPToolResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.HTTPToolResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Http, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.MCPToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.MCPToolResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.MCPToolResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.FileSearchToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.FileSearchToolResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.FileSearchToolResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AI21.WebSearchToolResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AI21.WebSearchToolResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AI21.WebSearchToolResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
        }
    }
}