#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class V1ModifyAssistantCommandApiCommand
{
    private static Argument<string> AssistantId { get; } = new(
        name: @"assistant-id")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<global::AI21.RunOptimization?> Optimization { get; } = new(
        name: @"--optimization")
    {
        Description = @"An enumeration.",
    };

    private static Option<string?> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"",
    };

    private static Option<bool?> IsArchived { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-archived",
        description: @"");

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>?> Requirements { get; } = new(
        name: @"--requirements")
    {
        Description = @"",
    };

    private static Option<global::AI21.BudgetLevel?> Budget { get; } = new(
        name: @"--budget")
    {
        Description = @"An enumeration.",
    };

    private static Option<global::AI21.Visibility?> Visibility { get; } = new(
        name: @"--visibility")
    {
        Description = @"An enumeration.",
    };

    private static Option<global::AI21.ModifyAssistantRequestResponseLanguage?> ResponseLanguage { get; } = new(
        name: @"--response-language")
    {
        Description = @"",
    };

    private static Option<string?> SystemPrompt { get; } = new(
        name: @"--system-prompt")
    {
        Description = @"",
    };

    private static Option<object?> ConfigOverrides { get; } = new(
        name: @"--config-overrides")
    {
        Description = @"",
    };
    private static readonly WorkflowConfigOptionSet WorkflowConfigOptions = WorkflowConfigOptionSet.Create(@"workflow-config");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.Assistant value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.Assistant value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-modify-assistant", @"Modify Assistant");
                        command.Arguments.Add(AssistantId);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Optimization);
                        command.Options.Add(Avatar);
                        command.Options.Add(IsArchived);
                        command.Options.Add(Models);
                        command.Options.Add(Tools);
                        command.Options.Add(Requirements);
                        command.Options.Add(Budget);
                        command.Options.Add(Visibility);
                        command.Options.Add(ResponseLanguage);
                        command.Options.Add(SystemPrompt);
                        command.Options.Add(ConfigOverrides);                        command.Options.Add(WorkflowConfigOptions.EndpointUrl);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.ModifyAssistantRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var assistantId = parseResult.GetRequiredValue(AssistantId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var optimization = CliRuntime.WasSpecified(parseResult, Optimization) ? parseResult.GetValue(Optimization) : (__requestBase is { } __OptimizationBaseValue ? __OptimizationBaseValue.Optimization : default);
                        var avatar = CliRuntime.WasSpecified(parseResult, Avatar) ? parseResult.GetValue(Avatar) : (__requestBase is { } __AvatarBaseValue ? __AvatarBaseValue.Avatar : default);
                        var isArchived = CliRuntime.WasSpecified(parseResult, IsArchived) ? parseResult.GetValue(IsArchived) : (__requestBase is { } __IsArchivedBaseValue ? __IsArchivedBaseValue.IsArchived : default);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var requirements = CliRuntime.WasSpecified(parseResult, Requirements) ? parseResult.GetValue(Requirements) : (__requestBase is { } __RequirementsBaseValue ? __RequirementsBaseValue.Requirements : default);
                        var budget = CliRuntime.WasSpecified(parseResult, Budget) ? parseResult.GetValue(Budget) : (__requestBase is { } __BudgetBaseValue ? __BudgetBaseValue.Budget : default);
                        var visibility = CliRuntime.WasSpecified(parseResult, Visibility) ? parseResult.GetValue(Visibility) : (__requestBase is { } __VisibilityBaseValue ? __VisibilityBaseValue.Visibility : default);
                        var responseLanguage = CliRuntime.WasSpecified(parseResult, ResponseLanguage) ? parseResult.GetValue(ResponseLanguage) : (__requestBase is { } __ResponseLanguageBaseValue ? __ResponseLanguageBaseValue.ResponseLanguage : default);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, SystemPrompt) ? parseResult.GetValue(SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);
                        var configOverrides = CliRuntime.WasSpecified(parseResult, ConfigOverrides) ? parseResult.GetValue(ConfigOverrides) : (__requestBase is { } __ConfigOverridesBaseValue ? __ConfigOverridesBaseValue.ConfigOverrides : default);

                        var __WorkflowConfigBase = __requestBase is { } __WorkflowConfigBaseValue ? __WorkflowConfigBaseValue.WorkflowConfig : default;                        var workflowConfigEndpointUrl = parseResult.GetValue(WorkflowConfigOptions.EndpointUrl);
                        var __WorkflowConfigSpecified = CliRuntime.WasSpecified(parseResult, WorkflowConfigOptions.EndpointUrl);
                        var workflowConfig =
                            __WorkflowConfigSpecified || __WorkflowConfigBase is not null
                                ? new global::AI21.WorkflowConfig
                                {
	                                EndpointUrl = workflowConfigEndpointUrl!,

                                }
                                : __WorkflowConfigBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.V1ModifyAssistantAsync(
                                    assistantId: assistantId,
                                    name: name,
                                    description: description,
                                    optimization: optimization,
                                    avatar: avatar,
                                    isArchived: isArchived,
                                    models: models,
                                    tools: tools,
                                    requirements: requirements,
                                    budget: budget,
                                    visibility: visibility,
                                    responseLanguage: responseLanguage,
                                    systemPrompt: systemPrompt,
                                    configOverrides: configOverrides,
                                    workflowConfig: workflowConfig,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AI21.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}