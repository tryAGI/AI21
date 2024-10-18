using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesItem : global::System.IEquatable<MessagesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.UserMessage? UserMessage { get; init; }
#else
        public global::AI21.UserMessage? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::AI21.UserMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.UserMessage?(MessagesItem @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::AI21.UserMessage? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.AssistantMessage? AssistantMessage { get; init; }
#else
        public global::AI21.AssistantMessage? AssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage))]
#endif
        public bool IsAssistantMessage => AssistantMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::AI21.AssistantMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.AssistantMessage?(MessagesItem @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::AI21.AssistantMessage? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.ToolMessage? ToolMessage { get; init; }
#else
        public global::AI21.ToolMessage? ToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMessage))]
#endif
        public bool IsToolMessage => ToolMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::AI21.ToolMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.ToolMessage?(MessagesItem @this) => @this.ToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::AI21.ToolMessage? value)
        {
            ToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.SystemMessage? SystemMessage { get; init; }
#else
        public global::AI21.SystemMessage? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::AI21.SystemMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.SystemMessage?(MessagesItem @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::AI21.SystemMessage? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(
            global::AI21.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole? role,
            global::AI21.UserMessage? userMessage,
            global::AI21.AssistantMessage? assistantMessage,
            global::AI21.ToolMessage? toolMessage,
            global::AI21.SystemMessage? systemMessage
            )
        {
            Role = role;

            UserMessage = userMessage;
            AssistantMessage = assistantMessage;
            ToolMessage = toolMessage;
            SystemMessage = systemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SystemMessage as object ??
            ToolMessage as object ??
            AssistantMessage as object ??
            UserMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsAssistantMessage && !IsToolMessage && !IsSystemMessage || !IsUserMessage && IsAssistantMessage && !IsToolMessage && !IsSystemMessage || !IsUserMessage && !IsAssistantMessage && IsToolMessage && !IsSystemMessage || !IsUserMessage && !IsAssistantMessage && !IsToolMessage && IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AI21.UserMessage?, TResult>? userMessage = null,
            global::System.Func<global::AI21.AssistantMessage?, TResult>? assistantMessage = null,
            global::System.Func<global::AI21.ToolMessage?, TResult>? toolMessage = null,
            global::System.Func<global::AI21.SystemMessage?, TResult>? systemMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsAssistantMessage && assistantMessage != null)
            {
                return assistantMessage(AssistantMessage!);
            }
            else if (IsToolMessage && toolMessage != null)
            {
                return toolMessage(ToolMessage!);
            }
            else if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AI21.UserMessage?>? userMessage = null,
            global::System.Action<global::AI21.AssistantMessage?>? assistantMessage = null,
            global::System.Action<global::AI21.ToolMessage?>? toolMessage = null,
            global::System.Action<global::AI21.SystemMessage?>? systemMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
            else if (IsToolMessage)
            {
                toolMessage?.Invoke(ToolMessage!);
            }
            else if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMessage,
                typeof(global::AI21.UserMessage),
                AssistantMessage,
                typeof(global::AI21.AssistantMessage),
                ToolMessage,
                typeof(global::AI21.ToolMessage),
                SystemMessage,
                typeof(global::AI21.SystemMessage),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MessagesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AI21.UserMessage?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::AI21.AssistantMessage?>.Default.Equals(AssistantMessage, other.AssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::AI21.ToolMessage?>.Default.Equals(ToolMessage, other.ToolMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::AI21.SystemMessage?>.Default.Equals(SystemMessage, other.SystemMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesItem obj1, MessagesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesItem obj1, MessagesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesItem o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::AI21.MessagesItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::AI21.MessagesItem),
                jsonSerializerContext) as global::AI21.MessagesItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::AI21.MessagesItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::AI21.MessagesItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
