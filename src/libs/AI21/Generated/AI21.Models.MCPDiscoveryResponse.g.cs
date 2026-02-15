
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPDiscoveryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.MCPDefinition McpDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.MCPTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPDiscoveryResponse" /> class.
        /// </summary>
        /// <param name="mcpDefinition"></param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPDiscoveryResponse(
            global::AI21.MCPDefinition mcpDefinition,
            global::System.Collections.Generic.IList<global::AI21.MCPTool> tools)
        {
            this.McpDefinition = mcpDefinition ?? throw new global::System.ArgumentNullException(nameof(mcpDefinition));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPDiscoveryResponse" /> class.
        /// </summary>
        public MCPDiscoveryResponse()
        {
        }
    }
}