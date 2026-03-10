
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DemoCreate
    {
        /// <summary>
        /// Name of the demo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Visibility of the demo (public/private)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.DemoVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.DemoVisibility Visibility { get; set; }

        /// <summary>
        /// Status of the demo (active/inactive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.DemoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.DemoStatus Status { get; set; }

        /// <summary>
        /// Demo configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Name of the UI component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_component_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UiComponentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the demo
        /// </param>
        /// <param name="visibility">
        /// Visibility of the demo (public/private)
        /// </param>
        /// <param name="status">
        /// Status of the demo (active/inactive)
        /// </param>
        /// <param name="config">
        /// Demo configuration
        /// </param>
        /// <param name="uiComponentName">
        /// Name of the UI component
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DemoCreate(
            string name,
            global::AI21.DemoVisibility visibility,
            global::AI21.DemoStatus status,
            string uiComponentName,
            object? config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
            this.Status = status;
            this.UiComponentName = uiComponentName ?? throw new global::System.ArgumentNullException(nameof(uiComponentName));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoCreate" /> class.
        /// </summary>
        public DemoCreate()
        {
        }
    }
}