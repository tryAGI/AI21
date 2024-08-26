
#nullable enable

namespace AI21
{
    /// <summary>
    /// The role of an individual message.<br/>
    /// - `user`:  Input provided by the user. Any instructions given here that conflict<br/>
    ///   with instructions given in the `system` prompt take precedence over the `system`<br/>
    ///   prompt instructions.<br/>
    /// - `assistant`:  Response generated by the model.<br/>
    /// - `system`:  Initial instructions provided to the system to provide general guidance<br/>
    ///   on the tone and voice of the generated message. An initial system message is<br/>
    ///   optional but recommended to provide guidance on the tone of the chat. For<br/>
    ///   example, "You are a helpful chatbot with a background in earth sciences and a<br/>
    ///   charming French accent."
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageRole value)
        {
            return value switch
            {
                MessageRole.Assistant => "assistant",
                MessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageRole.Assistant,
                "user" => MessageRole.User,
                _ => null,
            };
        }
    }
}