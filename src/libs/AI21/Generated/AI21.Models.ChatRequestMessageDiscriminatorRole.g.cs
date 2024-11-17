
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestMessageDiscriminatorRole value)
        {
            return value switch
            {
                ChatRequestMessageDiscriminatorRole.User => "user",
                ChatRequestMessageDiscriminatorRole.Assistant => "assistant",
                ChatRequestMessageDiscriminatorRole.Tool => "tool",
                ChatRequestMessageDiscriminatorRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatRequestMessageDiscriminatorRole.User,
                "assistant" => ChatRequestMessageDiscriminatorRole.Assistant,
                "tool" => ChatRequestMessageDiscriminatorRole.Tool,
                "system" => ChatRequestMessageDiscriminatorRole.System,
                _ => null,
            };
        }
    }
}