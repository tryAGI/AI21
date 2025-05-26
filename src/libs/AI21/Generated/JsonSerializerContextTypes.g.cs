
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Assistant? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AssistantTool2? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AssistantToolResource? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AssistantMessage? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AssistantMessageRole? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCall>? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCall? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallType? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolFunction? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AssistantRoute? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.BodyConvertDocumentFileStudioV1ChatFilesConvertPost? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.BodyV1LibraryUpload? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletion? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseChoice>? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletionResponseChoice? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Logprobs? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.LogprobsData>? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LogprobsData? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.TopLogprobsData>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.TopLogprobsData? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UsageInfo? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletionResponseDeltaChoice? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingFirstDelta? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingFirstDeltaRole? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingContentDelta? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingToolCallsFirstDelta? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart>? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallDeltaStart? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallDeltaStartType? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolFunctionDeltaStart? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingToolCallsDelta? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCallDelta>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallDelta? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolFunctionDelta? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletionVllmStreamingMessage? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseDeltaChoice>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatRequest? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ModelName? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.MessagesItem>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MessagesItem? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UserMessage? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UserMessageRole? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolMessage? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolMessageRole? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.SystemMessage? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.SystemMessageRole? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatRequestMessageDiscriminator? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatRequestMessageDiscriminatorRole? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolDefinition>? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolDefinition? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolDefinitionType? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FunctionToolDefinition? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolParameters? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolParametersType? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MockResponseConfig? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DocumentSchema? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ResponseFormat? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ResponseFormatType? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CompareTextRequest? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsDataSources? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.DataSourceMetadata>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DataSourceMetadata? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsStatus? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsWorkflowStatus? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsToken? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagConfig? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Message>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Message? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MessageRole? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagConfigRetrievalStrategy? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagConfigResponseLanguage? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagResult? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ConversationalRagSource>? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagSource? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateMaestroRunsPayload? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadTool2? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolResources? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Requirement>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Requirement? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadBudget? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.OutputOptions>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.OutputOptions? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreatePlanPayload? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateRoutePayload? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateSecretPayload? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DeleteAssistantResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Demo? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoVisibility? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoStatus? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoCreate? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoUpdate? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DownloadModifiedDocumentRequest? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FileResponse? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FileStatus? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FilesUpdateRequest? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.HTTPValidationError? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ValidationError>? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ValidationError? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AnyOf<string, int?>>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<string, int?>? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LibrarySearchRequest? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.QueryFilter? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LibrarySearchRequestLabelsFilterMode? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.RetrievalStrategy? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ListAssistantsResponse? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Assistant>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ListPlansResponse? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Plan>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Plan? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ListRoutesResponse? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AssistantRoute>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MaestroRunResult? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MaestroRunResultStatus? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.SecretResponse? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UpdateRoutePayload? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UpdateSecretPayload? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ValidationResult? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WebsiteConnectorIngestUrlPayload? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WebsiteConnectorIngestWebsitePayload? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WorkspaceModelResponse? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WorkspaceModelUpdate? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WorkspaceModelsResponse? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.WorkspaceModelResponse>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.FileResponse>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Demo>? Type150 { get; set; }
    }
}