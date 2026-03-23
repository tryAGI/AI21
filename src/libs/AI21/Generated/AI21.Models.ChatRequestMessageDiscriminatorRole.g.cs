
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
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                ChatRequestMessageDiscriminatorRole.Assistant => "assistant",
                ChatRequestMessageDiscriminatorRole.System => "system",
                ChatRequestMessageDiscriminatorRole.Tool => "tool",
                ChatRequestMessageDiscriminatorRole.User => "user",
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
                "assistant" => ChatRequestMessageDiscriminatorRole.Assistant,
                "system" => ChatRequestMessageDiscriminatorRole.System,
                "tool" => ChatRequestMessageDiscriminatorRole.Tool,
                "user" => ChatRequestMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}