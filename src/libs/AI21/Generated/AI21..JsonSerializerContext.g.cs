
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::AI21.JsonConverters.AssistantResponseLanguageJsonConverter),

            typeof(global::AI21.JsonConverters.AssistantResponseLanguageNullableJsonConverter),

            typeof(global::AI21.JsonConverters.AssistantMessageRoleJsonConverter),

            typeof(global::AI21.JsonConverters.AssistantMessageRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.AssistantTypeJsonConverter),

            typeof(global::AI21.JsonConverters.AssistantTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.AuthenticationTypeJsonConverter),

            typeof(global::AI21.JsonConverters.AuthenticationTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.BudgetLevelJsonConverter),

            typeof(global::AI21.JsonConverters.BudgetLevelNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ChatRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::AI21.JsonConverters.ChatRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter),

            typeof(global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusJsonConverter),

            typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusNullableJsonConverter),

            typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadBudgetJsonConverter),

            typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadBudgetNullableJsonConverter),

            typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadVariantJsonConverter),

            typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadVariantNullableJsonConverter),

            typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadResponseLanguageJsonConverter),

            typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadResponseLanguageNullableJsonConverter),

            typeof(global::AI21.JsonConverters.DemoStatusJsonConverter),

            typeof(global::AI21.JsonConverters.DemoStatusNullableJsonConverter),

            typeof(global::AI21.JsonConverters.DemoVisibilityJsonConverter),

            typeof(global::AI21.JsonConverters.DemoVisibilityNullableJsonConverter),

            typeof(global::AI21.JsonConverters.FileSearchToolResourceTypeJsonConverter),

            typeof(global::AI21.JsonConverters.FileSearchToolResourceTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.FileSearchToolResourceLabelsFilterModeJsonConverter),

            typeof(global::AI21.JsonConverters.FileSearchToolResourceLabelsFilterModeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.FileSearchToolResourceResponseLanguageJsonConverter),

            typeof(global::AI21.JsonConverters.FileSearchToolResourceResponseLanguageNullableJsonConverter),

            typeof(global::AI21.JsonConverters.FileStatusJsonConverter),

            typeof(global::AI21.JsonConverters.FileStatusNullableJsonConverter),

            typeof(global::AI21.JsonConverters.GenerateAssistantResponseResponseLanguageJsonConverter),

            typeof(global::AI21.JsonConverters.GenerateAssistantResponseResponseLanguageNullableJsonConverter),

            typeof(global::AI21.JsonConverters.HTTPToolFunctionParametersTypeJsonConverter),

            typeof(global::AI21.JsonConverters.HTTPToolFunctionParametersTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.HTTPToolResourceTypeJsonConverter),

            typeof(global::AI21.JsonConverters.HTTPToolResourceTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.LibrarySearchRequestLabelsFilterModeJsonConverter),

            typeof(global::AI21.JsonConverters.LibrarySearchRequestLabelsFilterModeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.MCPToolResourceTypeJsonConverter),

            typeof(global::AI21.JsonConverters.MCPToolResourceTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.MaestroRunResultStatusJsonConverter),

            typeof(global::AI21.JsonConverters.MaestroRunResultStatusNullableJsonConverter),

            typeof(global::AI21.JsonConverters.MessageRoleJsonConverter),

            typeof(global::AI21.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ModelNameJsonConverter),

            typeof(global::AI21.JsonConverters.ModelNameNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ModelQuantizationJsonConverter),

            typeof(global::AI21.JsonConverters.ModelQuantizationNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ModifyAssistantRequestResponseLanguageJsonConverter),

            typeof(global::AI21.JsonConverters.ModifyAssistantRequestResponseLanguageNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ParagonSyncStatusJsonConverter),

            typeof(global::AI21.JsonConverters.ParagonSyncStatusNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::AI21.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.RetrievalStrategyJsonConverter),

            typeof(global::AI21.JsonConverters.RetrievalStrategyNullableJsonConverter),

            typeof(global::AI21.JsonConverters.RunAssistantRequestResponseLanguageJsonConverter),

            typeof(global::AI21.JsonConverters.RunAssistantRequestResponseLanguageNullableJsonConverter),

            typeof(global::AI21.JsonConverters.RunOptimizationJsonConverter),

            typeof(global::AI21.JsonConverters.RunOptimizationNullableJsonConverter),

            typeof(global::AI21.JsonConverters.SystemMessageRoleJsonConverter),

            typeof(global::AI21.JsonConverters.SystemMessageRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ToolCallTypeJsonConverter),

            typeof(global::AI21.JsonConverters.ToolCallTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ToolCallDeltaStartTypeJsonConverter),

            typeof(global::AI21.JsonConverters.ToolCallDeltaStartTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ToolMessageRoleJsonConverter),

            typeof(global::AI21.JsonConverters.ToolMessageRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.ToolParametersTypeJsonConverter),

            typeof(global::AI21.JsonConverters.ToolParametersTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.UploadModeJsonConverter),

            typeof(global::AI21.JsonConverters.UploadModeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.UserMessageRoleJsonConverter),

            typeof(global::AI21.JsonConverters.UserMessageRoleNullableJsonConverter),

            typeof(global::AI21.JsonConverters.VisibilityJsonConverter),

            typeof(global::AI21.JsonConverters.VisibilityNullableJsonConverter),

            typeof(global::AI21.JsonConverters.WebSearchToolResourceTypeJsonConverter),

            typeof(global::AI21.JsonConverters.WebSearchToolResourceTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.WebsiteConnectorPayloadTypeJsonConverter),

            typeof(global::AI21.JsonConverters.WebsiteConnectorPayloadTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatToolDefinitionTypeJsonConverter),

            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatToolDefinitionTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorTypeJsonConverter),

            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorTypeNullableJsonConverter),

            typeof(global::AI21.JsonConverters.MessagesItemJsonConverter),

            typeof(global::AI21.JsonConverters.QueryFilterJsonConverter),

            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionJsonConverter),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::AI21.Message>, string>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>),

            typeof(global::AI21.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Assistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.BudgetLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Visibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantResponseLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.StarterQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.StarterQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WorkflowConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantBasicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantsByMcpResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.AssistantBasicInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AuthenticationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.BodyConvertDocumentFileStudioV1ChatFilesConvertPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.BodyV1LibraryUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UploadMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Logprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletionResponseDeltaChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingFirstDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingContentDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingToolCallsFirstDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingToolCallsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletionVllmStreamingMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseDeltaChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MessagesItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequestMessageDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MockResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.DocumentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DocumentSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingFirstDeltaRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ToolCallDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDeltaStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CompareTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ConnectorConnectionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ParagonSyncStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ConnectorsDataSources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.DataSourceMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DataSourceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ConnectorsStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ConnectorsWorkflowStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ConnectorsSyncParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ConnectorsToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateMCPStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateMaestroRunsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateMaestroRunsPayloadBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateMaestroRunsPayloadVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateMaestroRunsPayloadResponseLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateOrganizationSchemaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreatePlanPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateRoutePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.CreateSecretPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DeleteAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DeleteMCPStorageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Demo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DemoVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DemoStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DemoCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DemoUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DetectSchemaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.DocumentReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DocumentReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DetectSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DownloadModifiedDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FileSearchToolResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FileSearchToolResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FileSearchToolResourceLabelsFilterMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.QueryFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RetrievalStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FileSearchToolResourceResponseLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FilesUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FunctionToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.GenerateAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.GenerateAssistantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.GenerateAssistantResponseResponseLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolFunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolFunctionParamProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolFunctionParametersType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::AI21.HTTPToolFunctionParamProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPToolResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.IgnestionBatchStatusCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.IngestionBatchStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.IgnestionBatchStatusCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.JambaExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LibrarySearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LibrarySearchRequestLabelsFilterMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ListAssistantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ListMCPsStorageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.MCPStorageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MCPStorageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ListPlansResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.Plan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Plan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ListRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.AssistantRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LogprobsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.TopLogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.TopLogprobsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MCPDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MCPDiscoveryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MCPToolResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MCPToolResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MaestroRunError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MaestroRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MaestroRunResultStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MarkdownRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelsInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModifyAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RunOptimization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModifyAssistantRequestResponseLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.OrgSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.OrgSchemas))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.OrgSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RFIResponseSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RequirementItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RequirementsGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RequirementsGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.RequirementItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ResponseFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RunAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.RunAssistantRequestResponseLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.SecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.SystemMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ThreadNameGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ThreadNameGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolFunctionDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDeltaStartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolFunctionDeltaStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolParametersType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UpdateMCPStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UpdateRoutePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UpdateSecretPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UserMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebSearchToolResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebSearchToolResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebsiteConnectorCreateConfigPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebsiteConnectorIngestUrlPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebsiteConnectorIngestWebsitePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebsiteConnectorPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebsiteConnectorPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WebsiteConnectorRetryIngestWebsitePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WorkspaceModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WorkspaceModelUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.WorkspaceModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.WorkspaceModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.Demo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.RFIResponseSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.StarterQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.AssistantBasicInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ChatCompletionResponseDeltaChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.DocumentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ToolCallDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ToolCallDeltaStart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.DataSourceMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::System.Collections.Generic.List<global::AI21.Message>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.DocumentReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.IgnestionBatchStatusCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.MCPStorageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.Plan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.AssistantRoute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.TopLogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.OrgSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.RequirementItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.WorkspaceModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.List<global::AI21.ChatCompletionVllmStreamingMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ChatCompletionVllmStreamingMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.Demo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.RFIResponseSection>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}