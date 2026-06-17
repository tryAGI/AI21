#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class WebsiteConnectorV1WebsiteConnectorCreateConfigCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"",
    };

    private static Option<bool?> ExtractLinkedFiles { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--extract-linked-files",
        description: @"");

    private static Option<bool?> WaitForDynamicContent { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--wait-for-dynamic-content",
        description: @"");

    private static Option<global::System.Collections.Generic.IList<string>> SkipUrlPatterns { get; } = new(
        name: @"--skip-url-patterns")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>> TargetFileExtensions { get; } = new(
        name: @"--target-file-extensions")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Localization { get; } = new(
        name: @"--localization")
    {
        Description = @"",
    };
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

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-website-connector-create-config", @"Create Client Config");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(ExtractLinkedFiles);
                        command.Options.Add(WaitForDynamicContent);
                        command.Options.Add(SkipUrlPatterns);
                        command.Options.Add(TargetFileExtensions);
                        command.Options.Add(Localization);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.WebsiteConnectorCreateConfigPayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var extractLinkedFiles = CliRuntime.WasSpecified(parseResult, ExtractLinkedFiles) ? parseResult.GetValue(ExtractLinkedFiles) : (__requestBase is { } __ExtractLinkedFilesBaseValue ? __ExtractLinkedFilesBaseValue.ExtractLinkedFiles : default);
                        var waitForDynamicContent = CliRuntime.WasSpecified(parseResult, WaitForDynamicContent) ? parseResult.GetValue(WaitForDynamicContent) : (__requestBase is { } __WaitForDynamicContentBaseValue ? __WaitForDynamicContentBaseValue.WaitForDynamicContent : default);
                        var skipUrlPatterns = parseResult.GetRequiredValue(SkipUrlPatterns);
                        var targetFileExtensions = parseResult.GetRequiredValue(TargetFileExtensions);
                        var localization = CliRuntime.WasSpecified(parseResult, Localization) ? parseResult.GetValue(Localization) : (__requestBase is { } __LocalizationBaseValue ? __LocalizationBaseValue.Localization : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebsiteConnector.V1WebsiteConnectorCreateConfigAsync(
                                    name: name,
                                    extractLinkedFiles: extractLinkedFiles,
                                    waitForDynamicContent: waitForDynamicContent,
                                    skipUrlPatterns: skipUrlPatterns,
                                    targetFileExtensions: targetFileExtensions,
                                    localization: localization,
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