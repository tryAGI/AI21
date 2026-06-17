#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class McpToolDiscoveryStudioV1McpDiscoverPostCommandApiCommand
{
    private static Option<string> ServerUrl { get; } = new(
        name: @"--server-url")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> ServerLabel { get; } = new(
        name: @"--server-label")
    {
        Description = @"",
    };

    private static Option<object?> Headers { get; } = new(
        name: @"--headers")
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.MCPDiscoveryResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.MCPDiscoveryResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"mcp-tool-discovery-studio-v1-mcp-discover-post", @"Mcp Tool Discovery");
                        command.Options.Add(ServerUrl);
                        command.Options.Add(ServerLabel);
                        command.Options.Add(Headers);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.MCPDefinition>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var serverUrl = parseResult.GetRequiredValue(ServerUrl);
                        var serverLabel = CliRuntime.WasSpecified(parseResult, ServerLabel) ? parseResult.GetValue(ServerLabel) : (__requestBase is { } __ServerLabelBaseValue ? __ServerLabelBaseValue.ServerLabel : default);
                        var headers = CliRuntime.WasSpecified(parseResult, Headers) ? parseResult.GetValue(Headers) : (__requestBase is { } __HeadersBaseValue ? __HeadersBaseValue.Headers : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.McpToolDiscoveryStudioV1McpDiscoverPostAsync(
                                    serverUrl: serverUrl,
                                    serverLabel: serverLabel,
                                    headers: headers,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AI21.SourceGenerationContext.Default,
                                        @"Tools",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AI21.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}