#nullable enable

namespace AI21.JsonConverters
{
    /// <inheritdoc />
    public sealed class HTTPToolFunctionParametersTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AI21.HTTPToolFunctionParametersType?>
    {
        /// <inheritdoc />
        public override global::AI21.HTTPToolFunctionParametersType? Read(
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
                        return global::AI21.HTTPToolFunctionParametersTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AI21.HTTPToolFunctionParametersType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AI21.HTTPToolFunctionParametersType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AI21.HTTPToolFunctionParametersType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AI21.HTTPToolFunctionParametersTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
