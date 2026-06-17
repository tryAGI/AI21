#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class V1CreateAssistantCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<string?> Optimization { get; } = new(
        name: @"--optimization")
    {
        Description = @"",
    };

    private static Option<string?> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"",
    };

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
        Description = @"",
    };

    private static Option<global::AI21.AssistantType?> AssistantType { get; } = new(
        name: @"--assistant-type")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.StarterQuestion>?> StarterQuestions { get; } = new(
        name: @"--starter-questions")
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
        var command = new Command(@"v1-create-assistant", @"Create Assistant");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Optimization);
                        command.Options.Add(Avatar);
                        command.Options.Add(Models);
                        command.Options.Add(Tools);
                        command.Options.Add(Requirements);
                        command.Options.Add(Budget);
                        command.Options.Add(AssistantType);
                        command.Options.Add(StarterQuestions);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.CreateAssistantRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var optimization = CliRuntime.WasSpecified(parseResult, Optimization) ? parseResult.GetValue(Optimization) : (__requestBase is { } __OptimizationBaseValue ? __OptimizationBaseValue.Optimization : default);
                        var avatar = CliRuntime.WasSpecified(parseResult, Avatar) ? parseResult.GetValue(Avatar) : (__requestBase is { } __AvatarBaseValue ? __AvatarBaseValue.Avatar : default);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var requirements = CliRuntime.WasSpecified(parseResult, Requirements) ? parseResult.GetValue(Requirements) : (__requestBase is { } __RequirementsBaseValue ? __RequirementsBaseValue.Requirements : default);
                        var budget = CliRuntime.WasSpecified(parseResult, Budget) ? parseResult.GetValue(Budget) : (__requestBase is { } __BudgetBaseValue ? __BudgetBaseValue.Budget : default);
                        var assistantType = CliRuntime.WasSpecified(parseResult, AssistantType) ? parseResult.GetValue(AssistantType) : (__requestBase is { } __AssistantTypeBaseValue ? __AssistantTypeBaseValue.AssistantType : default);
                        var starterQuestions = CliRuntime.WasSpecified(parseResult, StarterQuestions) ? parseResult.GetValue(StarterQuestions) : (__requestBase is { } __StarterQuestionsBaseValue ? __StarterQuestionsBaseValue.StarterQuestions : default);
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


                                var response = await client.V1CreateAssistantAsync(
                                    name: name,
                                    description: description,
                                    optimization: optimization,
                                    avatar: avatar,
                                    models: models,
                                    tools: tools,
                                    requirements: requirements,
                                    budget: budget,
                                    assistantType: assistantType,
                                    starterQuestions: starterQuestions,
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