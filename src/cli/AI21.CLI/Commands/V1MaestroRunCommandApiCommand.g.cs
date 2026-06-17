#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class V1MaestroRunCommandApiCommand
{
    private static Option<global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string>> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
        Required = true,
    };

    private static Option<object?> OutputType { get; } = new(
        name: @"--output-type")
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

    private static Option<object?> Context { get; } = new(
        name: @"--context")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>?> Requirements { get; } = new(
        name: @"--requirements")
    {
        Description = @"",
    };

    private static Option<global::AI21.CreateMaestroRunsPayloadBudget?> Budget { get; } = new(
        name: @"--budget")
    {
        Description = @"",
    };

    private static Option<bool?> Verbose { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--verbose",
        description: @"");

    private static Option<global::System.Collections.Generic.IList<string>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"",
    };

    private static Option<bool?> StructuredRagEnabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--structured-rag-enabled",
        description: @"");

    private static Option<bool?> DynamicPlanningEnabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dynamic-planning-enabled",
        description: @"");

    private static Option<string?> AssistantId { get; } = new(
        name: @"--assistant-id")
    {
        Description = @"",
    };

    private static Option<global::AI21.CreateMaestroRunsPayloadVariant?> Variant { get; } = new(
        name: @"--variant")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<object>?> CustomRetrievalConfigs { get; } = new(
        name: @"--custom-retrieval-configs")
    {
        Description = @"",
    };

    private static Option<global::AI21.CreateMaestroRunsPayloadResponseLanguage?> ResponseLanguage { get; } = new(
        name: @"--response-language")
    {
        Description = @"",
    };

    private static Option<string?> SystemPrompt { get; } = new(
        name: @"--system-prompt")
    {
        Description = @"",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"Whether or not to stream the result one token at a time using
[server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).
This can be useful when waiting for long results where a long wait time for an
answer can be problematic, such as a chatbot. If set to `True`, then `n` must
be 1. A streaming response is different than the non-streaming response.
");
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.MaestroRunResult value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.MaestroRunResult value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-maestro-run", @"Create Maestro Run");
                        command.Options.Add(InputOption);
                        command.Options.Add(OutputType);
                        command.Options.Add(Models);
                        command.Options.Add(Tools);
                        command.Options.Add(Context);
                        command.Options.Add(Requirements);
                        command.Options.Add(Budget);
                        command.Options.Add(Verbose);
                        command.Options.Add(Include);
                        command.Options.Add(StructuredRagEnabled);
                        command.Options.Add(DynamicPlanningEnabled);
                        command.Options.Add(AssistantId);
                        command.Options.Add(Variant);
                        command.Options.Add(CustomRetrievalConfigs);
                        command.Options.Add(ResponseLanguage);
                        command.Options.Add(SystemPrompt);
                        command.Options.Add(Stream);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.CreateMaestroRunsPayload>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var outputType = CliRuntime.WasSpecified(parseResult, OutputType) ? parseResult.GetValue(OutputType) : (__requestBase is { } __OutputTypeBaseValue ? __OutputTypeBaseValue.OutputType : default);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var context = CliRuntime.WasSpecified(parseResult, Context) ? parseResult.GetValue(Context) : (__requestBase is { } __ContextBaseValue ? __ContextBaseValue.Context : default);
                        var requirements = CliRuntime.WasSpecified(parseResult, Requirements) ? parseResult.GetValue(Requirements) : (__requestBase is { } __RequirementsBaseValue ? __RequirementsBaseValue.Requirements : default);
                        var budget = CliRuntime.WasSpecified(parseResult, Budget) ? parseResult.GetValue(Budget) : (__requestBase is { } __BudgetBaseValue ? __BudgetBaseValue.Budget : default);
                        var verbose = CliRuntime.WasSpecified(parseResult, Verbose) ? parseResult.GetValue(Verbose) : (__requestBase is { } __VerboseBaseValue ? __VerboseBaseValue.Verbose : default);
                        var include = CliRuntime.WasSpecified(parseResult, Include) ? parseResult.GetValue(Include) : (__requestBase is { } __IncludeBaseValue ? __IncludeBaseValue.Include : default);
                        var structuredRagEnabled = CliRuntime.WasSpecified(parseResult, StructuredRagEnabled) ? parseResult.GetValue(StructuredRagEnabled) : (__requestBase is { } __StructuredRagEnabledBaseValue ? __StructuredRagEnabledBaseValue.StructuredRagEnabled : default);
                        var dynamicPlanningEnabled = CliRuntime.WasSpecified(parseResult, DynamicPlanningEnabled) ? parseResult.GetValue(DynamicPlanningEnabled) : (__requestBase is { } __DynamicPlanningEnabledBaseValue ? __DynamicPlanningEnabledBaseValue.DynamicPlanningEnabled : default);
                        var assistantId = CliRuntime.WasSpecified(parseResult, AssistantId) ? parseResult.GetValue(AssistantId) : (__requestBase is { } __AssistantIdBaseValue ? __AssistantIdBaseValue.AssistantId : default);
                        var variant = CliRuntime.WasSpecified(parseResult, Variant) ? parseResult.GetValue(Variant) : (__requestBase is { } __VariantBaseValue ? __VariantBaseValue.Variant : default);
                        var customRetrievalConfigs = CliRuntime.WasSpecified(parseResult, CustomRetrievalConfigs) ? parseResult.GetValue(CustomRetrievalConfigs) : (__requestBase is { } __CustomRetrievalConfigsBaseValue ? __CustomRetrievalConfigsBaseValue.CustomRetrievalConfigs : default);
                        var responseLanguage = CliRuntime.WasSpecified(parseResult, ResponseLanguage) ? parseResult.GetValue(ResponseLanguage) : (__requestBase is { } __ResponseLanguageBaseValue ? __ResponseLanguageBaseValue.ResponseLanguage : default);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, SystemPrompt) ? parseResult.GetValue(SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.V1MaestroRunAsync(
                                    input: input,
                                    outputType: outputType,
                                    models: models,
                                    tools: tools,
                                    context: context,
                                    requirements: requirements,
                                    budget: budget,
                                    verbose: verbose,
                                    include: include,
                                    structuredRagEnabled: structuredRagEnabled,
                                    dynamicPlanningEnabled: dynamicPlanningEnabled,
                                    assistantId: assistantId,
                                    variant: variant,
                                    customRetrievalConfigs: customRetrievalConfigs,
                                    responseLanguage: responseLanguage,
                                    systemPrompt: systemPrompt,
                                    stream: stream,
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