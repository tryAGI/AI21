#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class UpdateMcpStorageStudioV1McpStorageMcpIdPatchCommandApiCommand
{
    private static Argument<string> McpId { get; } = new(
        name: @"mcp-id")
    {
        Description = @"",
    };

    private static Option<string> ServerLabel { get; } = new(
        name: @"--server-label")
    {
        Description = @"",
        Required = true,
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
        var command = new Command(@"update-mcp-storage-studio-v1-mcp-storage-mcp-id-patch", @"Update Mcp Storage");
                        command.Arguments.Add(McpId);
                        command.Options.Add(ServerLabel);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var mcpId = parseResult.GetRequiredValue(McpId);
                        var serverLabel = parseResult.GetRequiredValue(ServerLabel);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateMcpStorageStudioV1McpStorageMcpIdPatchAsync(
                                    mcpId: mcpId,
                                    serverLabel: serverLabel,
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