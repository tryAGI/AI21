#nullable enable

namespace AI21.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolCallDeltaStartTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AI21.ToolCallDeltaStartType>
    {
        /// <inheritdoc />
        public override global::AI21.ToolCallDeltaStartType Read(
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
                        return global::AI21.ToolCallDeltaStartTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AI21.ToolCallDeltaStartType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AI21.ToolCallDeltaStartType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AI21.ToolCallDeltaStartTypeExtensions.ToValueString(value));
        }
    }
}
