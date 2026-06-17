#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class CreateMcpStorageStudioV1McpStoragePostCommandApiCommand
{
    private static Option<string> ServerUrl { get; } = new(
        name: @"--server-url")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> ServerLabel { get; } = new(
        name: @"--server-label")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Guid?> WorkspaceId { get; } = new(
        name: @"--workspace-id")
    {
        Description = @"",
    };

    private static Option<global::AI21.AuthenticationType?> AuthenticationType { get; } = new(
        name: @"--authentication-type")
    {
        Description = @"An enumeration.",
    };

    private static Option<string?> AuthHeaderName { get; } = new(
        name: @"--auth-header-name")
    {
        Description = @"",
    };

    private static Option<string?> AuthValue { get; } = new(
        name: @"--auth-value")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AllowedTools { get; } = new(
        name: @"--allowed-tools")
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.MCPStorageResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.MCPStorageResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-mcp-storage-studio-v1-mcp-storage-post", @"Create Mcp Storage");
                        command.Options.Add(ServerUrl);
                        command.Options.Add(ServerLabel);
                        command.Options.Add(WorkspaceId);
                        command.Options.Add(AuthenticationType);
                        command.Options.Add(AuthHeaderName);
                        command.Options.Add(AuthValue);
                        command.Options.Add(AllowedTools);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.CreateMCPStorageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var serverUrl = parseResult.GetRequiredValue(ServerUrl);
                        var serverLabel = parseResult.GetRequiredValue(ServerLabel);
                        var workspaceId = CliRuntime.WasSpecified(parseResult, WorkspaceId) ? parseResult.GetValue(WorkspaceId) : (__requestBase is { } __WorkspaceIdBaseValue ? __WorkspaceIdBaseValue.WorkspaceId : default);
                        var authenticationType = CliRuntime.WasSpecified(parseResult, AuthenticationType) ? parseResult.GetValue(AuthenticationType) : (__requestBase is { } __AuthenticationTypeBaseValue ? __AuthenticationTypeBaseValue.AuthenticationType : default);
                        var authHeaderName = CliRuntime.WasSpecified(parseResult, AuthHeaderName) ? parseResult.GetValue(AuthHeaderName) : (__requestBase is { } __AuthHeaderNameBaseValue ? __AuthHeaderNameBaseValue.AuthHeaderName : default);
                        var authValue = CliRuntime.WasSpecified(parseResult, AuthValue) ? parseResult.GetValue(AuthValue) : (__requestBase is { } __AuthValueBaseValue ? __AuthValueBaseValue.AuthValue : default);
                        var allowedTools = CliRuntime.WasSpecified(parseResult, AllowedTools) ? parseResult.GetValue(AllowedTools) : (__requestBase is { } __AllowedToolsBaseValue ? __AllowedToolsBaseValue.AllowedTools : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateMcpStorageStudioV1McpStoragePostAsync(
                                    serverUrl: serverUrl,
                                    serverLabel: serverLabel,
                                    workspaceId: workspaceId,
                                    authenticationType: authenticationType,
                                    authHeaderName: authHeaderName,
                                    authValue: authValue,
                                    allowedTools: allowedTools,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AI21.SourceGenerationContext.Default,
                                        @"AllowedTools",
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