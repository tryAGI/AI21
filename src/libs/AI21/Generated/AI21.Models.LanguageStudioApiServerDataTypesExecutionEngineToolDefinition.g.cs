#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LanguageStudioApiServerDataTypesExecutionEngineToolDefinition : global::System.IEquatable<LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.HTTPToolResource? Http { get; init; }
#else
        public global::AI21.HTTPToolResource? Http { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Http))]
#endif
        public bool IsHttp => Http != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.HTTPToolResource value) => new LanguageStudioApiServerDataTypesExecutionEngineToolDefinition((global::AI21.HTTPToolResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.HTTPToolResource?(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition @this) => @this.Http;

        /// <summary>
        /// 
        /// </summary>
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.HTTPToolResource? value)
        {
            Http = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.MCPToolResource? Mcp { get; init; }
#else
        public global::AI21.MCPToolResource? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.MCPToolResource value) => new LanguageStudioApiServerDataTypesExecutionEngineToolDefinition((global::AI21.MCPToolResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.MCPToolResource?(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.MCPToolResource? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.FileSearchToolResource? FileSearch { get; init; }
#else
        public global::AI21.FileSearchToolResource? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.FileSearchToolResource value) => new LanguageStudioApiServerDataTypesExecutionEngineToolDefinition((global::AI21.FileSearchToolResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.FileSearchToolResource?(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.FileSearchToolResource? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AI21.WebSearchToolResource? WebSearch { get; init; }
#else
        public global::AI21.WebSearchToolResource? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.WebSearchToolResource value) => new LanguageStudioApiServerDataTypesExecutionEngineToolDefinition((global::AI21.WebSearchToolResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AI21.WebSearchToolResource?(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(global::AI21.WebSearchToolResource? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinition(
            global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType? type,
            global::AI21.HTTPToolResource? http,
            global::AI21.MCPToolResource? mcp,
            global::AI21.FileSearchToolResource? fileSearch,
            global::AI21.WebSearchToolResource? webSearch
            )
        {
            Type = type;

            Http = http;
            Mcp = mcp;
            FileSearch = fileSearch;
            WebSearch = webSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            FileSearch as object ??
            Mcp as object ??
            Http as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Http?.ToString() ??
            Mcp?.ToString() ??
            FileSearch?.ToString() ??
            WebSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsHttp && !IsMcp && !IsFileSearch && !IsWebSearch || !IsHttp && IsMcp && !IsFileSearch && !IsWebSearch || !IsHttp && !IsMcp && IsFileSearch && !IsWebSearch || !IsHttp && !IsMcp && !IsFileSearch && IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AI21.HTTPToolResource?, TResult>? http = null,
            global::System.Func<global::AI21.MCPToolResource?, TResult>? mcp = null,
            global::System.Func<global::AI21.FileSearchToolResource?, TResult>? fileSearch = null,
            global::System.Func<global::AI21.WebSearchToolResource?, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHttp && http != null)
            {
                return http(Http!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AI21.HTTPToolResource?>? http = null,
            global::System.Action<global::AI21.MCPToolResource?>? mcp = null,
            global::System.Action<global::AI21.FileSearchToolResource?>? fileSearch = null,
            global::System.Action<global::AI21.WebSearchToolResource?>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHttp)
            {
                http?.Invoke(Http!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Http,
                typeof(global::AI21.HTTPToolResource),
                Mcp,
                typeof(global::AI21.MCPToolResource),
                FileSearch,
                typeof(global::AI21.FileSearchToolResource),
                WebSearch,
                typeof(global::AI21.WebSearchToolResource),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AI21.HTTPToolResource?>.Default.Equals(Http, other.Http) &&
                global::System.Collections.Generic.EqualityComparer<global::AI21.MCPToolResource?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::AI21.FileSearchToolResource?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::AI21.WebSearchToolResource?>.Default.Equals(WebSearch, other.WebSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition obj1, LanguageStudioApiServerDataTypesExecutionEngineToolDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LanguageStudioApiServerDataTypesExecutionEngineToolDefinition obj1, LanguageStudioApiServerDataTypesExecutionEngineToolDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LanguageStudioApiServerDataTypesExecutionEngineToolDefinition o && Equals(o);
        }
    }
}
