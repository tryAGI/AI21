#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class V1RunAssistantCommandApiCommand
{
    private static Argument<string> AssistantId { get; } = new(
        name: @"assistant-id")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.Message>> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool?> Verbose { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--verbose",
        description: @"");

    private static Option<object?> OutputType { get; } = new(
        name: @"--output-type")
    {
        Description = @"",
    };

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

    private static Option<global::AI21.RunAssistantRequestResponseLanguage?> ResponseLanguage { get; } = new(
        name: @"--response-language")
    {
        Description = @"",
    };

    private static Option<string?> SystemPrompt { get; } = new(
        name: @"--system-prompt")
    {
        Description = @"",
    };
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
        var command = new Command(@"v1-run-assistant", @"Run Assistant");
                        command.Arguments.Add(AssistantId);
                        command.Options.Add(InputOption);
                        command.Options.Add(Verbose);
                        command.Options.Add(OutputType);
                        command.Options.Add(Include);
                        command.Options.Add(StructuredRagEnabled);
                        command.Options.Add(DynamicPlanningEnabled);
                        command.Options.Add(ResponseLanguage);
                        command.Options.Add(SystemPrompt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.RunAssistantRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var assistantId = parseResult.GetRequiredValue(AssistantId);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var verbose = CliRuntime.WasSpecified(parseResult, Verbose) ? parseResult.GetValue(Verbose) : (__requestBase is { } __VerboseBaseValue ? __VerboseBaseValue.Verbose : default);
                        var outputType = CliRuntime.WasSpecified(parseResult, OutputType) ? parseResult.GetValue(OutputType) : (__requestBase is { } __OutputTypeBaseValue ? __OutputTypeBaseValue.OutputType : default);
                        var include = CliRuntime.WasSpecified(parseResult, Include) ? parseResult.GetValue(Include) : (__requestBase is { } __IncludeBaseValue ? __IncludeBaseValue.Include : default);
                        var structuredRagEnabled = CliRuntime.WasSpecified(parseResult, StructuredRagEnabled) ? parseResult.GetValue(StructuredRagEnabled) : (__requestBase is { } __StructuredRagEnabledBaseValue ? __StructuredRagEnabledBaseValue.StructuredRagEnabled : default);
                        var dynamicPlanningEnabled = CliRuntime.WasSpecified(parseResult, DynamicPlanningEnabled) ? parseResult.GetValue(DynamicPlanningEnabled) : (__requestBase is { } __DynamicPlanningEnabledBaseValue ? __DynamicPlanningEnabledBaseValue.DynamicPlanningEnabled : default);
                        var responseLanguage = CliRuntime.WasSpecified(parseResult, ResponseLanguage) ? parseResult.GetValue(ResponseLanguage) : (__requestBase is { } __ResponseLanguageBaseValue ? __ResponseLanguageBaseValue.ResponseLanguage : default);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, SystemPrompt) ? parseResult.GetValue(SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.V1RunAssistantAsync(
                                    assistantId: assistantId,
                                    input: input,
                                    verbose: verbose,
                                    outputType: outputType,
                                    include: include,
                                    structuredRagEnabled: structuredRagEnabled,
                                    dynamicPlanningEnabled: dynamicPlanningEnabled,
                                    responseLanguage: responseLanguage,
                                    systemPrompt: systemPrompt,
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