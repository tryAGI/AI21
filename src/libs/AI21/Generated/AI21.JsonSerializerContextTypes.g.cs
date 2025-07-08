
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
        public global::AI21.BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.BodyV1LibraryUpload? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UploadMode? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletion? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseChoice>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletionResponseChoice? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Logprobs? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.LogprobsData>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LogprobsData? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.TopLogprobsData>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.TopLogprobsData? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UsageInfo? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletionResponseDeltaChoice? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingFirstDelta? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingFirstDeltaRole? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingContentDelta? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingToolCallsFirstDelta? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallDeltaStart? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallDeltaStartType? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolFunctionDeltaStart? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatStreamingToolCallsDelta? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCallDelta>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolCallDelta? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolFunctionDelta? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatCompletionVllmStreamingMessage? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseDeltaChoice>? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ModelName? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.MessagesItem>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MessagesItem? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UserMessage? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UserMessageRole? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolMessage? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolMessageRole? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.SystemMessage? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.SystemMessageRole? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatRequestMessageDiscriminator? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ChatRequestMessageDiscriminatorRole? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolDefinition>? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolDefinition? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolDefinitionType? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FunctionToolDefinition? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolParameters? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolParametersType? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MockResponseConfig? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DocumentSchema? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ResponseFormat? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ResponseFormatType? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CompareTextRequest? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsDataSources? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.DataSourceMetadata>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DataSourceMetadata? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsStatus? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsWorkflowStatus? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConnectorsToken? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConvRagExecuteRequest? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagConfig? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Message>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Message? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MessageRole? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagConfigRetrievalStrategy? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagConfigResponseLanguage? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagResult? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ConversationalRagSource>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ConversationalRagSource? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateMaestroRunsPayload? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadTool2? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ToolResources? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Requirement>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Requirement? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadBudget? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.OutputOptions>? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.OutputOptions? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MaestroPayloadType? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreatePlanPayload? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateRoutePayload? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.CreateSecretPayload? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DeleteAssistantResponse? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Demo? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoVisibility? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoStatus? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoCreate? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DemoUpdate? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.DownloadModifiedDocumentRequest? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FileResponse? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FileStatus? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.FilesUpdateRequest? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.HTTPValidationError? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ValidationError>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ValidationError? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AnyOf<string, int?>>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<string, int?>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.IgnestionBatchStatusCount? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.IngestionBatchStatusResponse? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.IgnestionBatchStatusCount>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.JambaExecuteRequest? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LibrarySearchRequest? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.QueryFilter? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.LibrarySearchRequestLabelsFilterMode? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.RetrievalStrategy? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ListAssistantsResponse? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Assistant>? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ListPlansResponse? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Plan>? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.Plan? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ListRoutesResponse? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AssistantRoute>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MaestroRunResult? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MaestroRunResultStatus? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.MarkdownRequest? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.RFIResponseSection? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.RequirementItem? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.RequirementsGenerationRequest? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.RequirementsGenerationResponse? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.RequirementItem>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.SecretResponse? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ThreadNameGenerationRequest? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ThreadNameGenerationResponse? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UpdateRoutePayload? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.UpdateSecretPayload? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.ValidationResult? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WebsiteConnectorCreateConfigPayload? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WebsiteConnectorIngestUrlPayload? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WebsiteConnectorIngestWebsitePayload? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WebsiteConnectorRetryIngestWebsitePayload? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WorkspaceModelResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WorkspaceModelUpdate? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.WorkspaceModelsResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.WorkspaceModelResponse>? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.FileResponse>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Demo>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.RFIResponseSection>? Type169 { get; set; }
    }
}