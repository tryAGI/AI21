
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::AI21.AgentCreate? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AgentOptimization? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AgentOut? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AgentUpdate? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.Assistant? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.BudgetLevel? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.Visibility? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantResponseLanguage? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.StarterQuestion>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.StarterQuestion? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WorkflowConfig? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantBasicInfo? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantMessage? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantMessageRole? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCall>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolCall? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantRoute? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AssistantsByMcpResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AssistantBasicInfo>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AuthenticationType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.BodyConvertDocumentFileStudioV1ChatFilesConvertPost? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.BodyV1LibraryUpload? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UploadMode? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatCompletion? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseChoice>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatCompletionResponseChoice? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UsageInfo? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.Logprobs? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatCompletionResponseDeltaChoice? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatStreamingFirstDelta? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatStreamingContentDelta? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatStreamingToolCallsFirstDelta? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatStreamingToolCallsDelta? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatCompletionVllmStreamingMessage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseDeltaChoice>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModelName? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.MessagesItem>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MessagesItem? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UserMessage? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolMessage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.SystemMessage? Type61 { get; set; }
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
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MockResponseConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.DocumentSchema>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DocumentSchema? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ResponseFormat? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ChatStreamingFirstDeltaRole? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCallDelta>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolCallDelta? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolCallDeltaStart? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CompareTextRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ComparisonOperator? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ConfigProfileCreate? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ConfigProfileOut? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ConfigProfileUpdate? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ConfigSchemaOut? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateAssistantRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateMCPStorageRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateMaestroRunsPayload? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string>? Type87 { get; set; }
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
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadBudget? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadVariant? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateMaestroRunsPayloadResponseLanguage? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateOrganizationSchemaRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreatePlanPayload? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateRoutePayload? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.CreateSecretPayload? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DeleteAssistantResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DeleteMCPStorageResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.Demo? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DemoVisibility? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DemoStatus? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DemoCreate? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DemoUpdate? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DetectSchemaRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.DocumentReference>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DocumentReference? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DetectSchemaResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.DownloadModifiedDocumentRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FileResponse? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FileSearchToolResource? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FileSearchToolResourceType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FileSearchToolResourceLabelsFilterMode? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.QueryFilter? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RetrievalStrategy? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FileSearchToolResourceResponseLanguage? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FileStatus? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FilesUpdateRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.FunctionToolDefinition? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolParameters? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.GenerateAssistantRequest? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.GenerateAssistantResponse? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.GenerateAssistantResponseResponseLanguage? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolEndpoint? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolFunction? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolFunctionParameters? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolFunctionParamProperties? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolFunctionParametersType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AI21.HTTPToolFunctionParamProperties>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolResource? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPToolResourceType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.HTTPValidationError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ValidationError>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ValidationError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.IgnestionBatchStatusCount? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.IngestionBatchStatusResponse? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.IgnestionBatchStatusCount>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.InsightFeedbackIn? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.InsightOut? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.JambaExecuteRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ListAssistantsResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Assistant>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ListMCPsStorageResponse? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.MCPStorageResponse>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MCPStorageResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ListPlansResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Plan>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.Plan? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ListRoutesResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AssistantRoute>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.LogprobsData>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LogprobsData? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.TopLogprobsData>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.TopLogprobsData? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MCPToolResource? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MCPToolResourceType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MaestroRunError? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MaestroRunResult? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MaestroRunResultStatus? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MarkdownRequest? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.MessageRole? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModelInfo? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModelQuantization? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModelPricing? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModelsInfoResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ModelInfo>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModifyAssistantRequest? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RunOptimization? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ModifyAssistantRequestResponseLanguage? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.OrgSchema? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.OrgSchemas? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.OrgSchema>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AI21.ComparisonOperator>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RFIResponseSection? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RequirementItem? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RequirementsGenerationRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RequirementsGenerationResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.RequirementItem>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ResponseFormatType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RunAssistantRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.RunAssistantRequestResponseLanguage? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.SecretResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.SystemMessageRole? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolCallType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolFunction? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolFunctionDelta? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolCallDeltaStartType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolFunctionDeltaStart? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolMessageRole? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ToolParametersType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UpdateMCPStorageRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UpdateRoutePayload? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UpdateSecretPayload? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.UserMessageRole? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AnyOf<string, int?>>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<string, int?>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.ValidationResult? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WebSearchToolResource? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WebSearchToolResourceType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WebsiteConnectorCreateConfigPayload? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WebsiteConnectorIngestUrlPayload? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WebsiteConnectorIngestWebsitePayload? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WebsiteConnectorRetryIngestWebsitePayload? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WorkspaceModelResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WorkspaceModelUpdate? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.WorkspaceModelsResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.WorkspaceModelResponse>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.FileResponse>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.Demo>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.RFIResponseSection>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AgentOut>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.AgentOptimization>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.ConfigProfileOut>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AI21.InsightOut>? Type223 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<string>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.StarterQuestion>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ToolCall>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.AssistantBasicInfo>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ChatCompletionResponseChoice>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ChatCompletionResponseDeltaChoice>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.MessagesItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.DocumentSchema>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ToolCallDelta>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ToolCallDeltaStart>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::System.Collections.Generic.List<global::AI21.Message>, string>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.Message>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.DocumentReference>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ValidationError>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.IgnestionBatchStatusCount>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.Assistant>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.MCPStorageResponse>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.Plan>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.AssistantRoute>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<object>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.LogprobsData>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.TopLogprobsData>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ModelInfo>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.OrgSchema>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.RequirementItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.AnyOf<string, int?>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.WorkspaceModelResponse>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.List<global::AI21.ChatCompletionVllmStreamingMessage>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ChatCompletionVllmStreamingMessage>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.FileResponse>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.Demo>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.RFIResponseSection>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.AgentOut>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.AgentOptimization>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.ConfigProfileOut>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AI21.InsightOut>? ListType44 { get; set; }
    }
}