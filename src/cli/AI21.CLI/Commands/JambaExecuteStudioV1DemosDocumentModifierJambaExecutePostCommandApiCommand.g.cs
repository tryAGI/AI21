#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class JambaExecuteStudioV1DemosDocumentModifierJambaExecutePostCommandApiCommand
{
    private static Option<string> Content { get; } = new(
        name: @"--content")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Task { get; } = new(
        name: @"--task")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> ApiKey { get; } = new(
        name: @"--api-key")
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
        var command = new Command(@"jamba-execute-studio-v1-demos-document-modifier-jamba-execute-post", @"Jamba Execute
Execute a Jamba request.");
                        command.Options.Add(Content);
                        command.Options.Add(Task);
                        command.Options.Add(Prompt);
                        command.Options.Add(ApiKey);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.JambaExecuteRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var content = parseResult.GetRequiredValue(Content);
                        var task = parseResult.GetRequiredValue(Task);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var apiKey = CliRuntime.WasSpecified(parseResult, ApiKey) ? parseResult.GetValue(ApiKey) : (__requestBase is { } __ApiKeyBaseValue ? __ApiKeyBaseValue.ApiKey : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.JambaExecuteStudioV1DemosDocumentModifierJambaExecutePostAsync(
                                    content: content,
                                    task: task,
                                    prompt: prompt,
                                    apiKey: apiKey,
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