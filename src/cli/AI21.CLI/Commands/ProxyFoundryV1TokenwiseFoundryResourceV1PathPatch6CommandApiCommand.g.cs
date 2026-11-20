#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class ProxyFoundryV1TokenwiseFoundryResourceV1PathPatch6CommandApiCommand
{
    private static Argument<string> Resource { get; } = new(
        name: @"resource")
    {
        Description = @"",
    };

    private static Argument<string> Path { get; } = new(
        name: @"path")
    {
        Description = @"",
    };

    private static Option<string?> XAi21Key { get; } = new(
        name: @"--x-ai21-key")
    {
        Description = @"",
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"proxy-foundry-v1-tokenwise-foundry-resource-v1-path-patch6", @"Proxy Foundry V1
Anthropic-compatible surface on a listed Microsoft Foundry resource.");
                        command.Arguments.Add(Resource);
                        command.Arguments.Add(Path);
                        command.Options.Add(XAi21Key);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var resource = parseResult.GetRequiredValue(Resource);
                        var path = parseResult.GetRequiredValue(Path);
                        var xAi21Key = parseResult.GetValue(XAi21Key);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ProxyFoundryV1TokenwiseFoundryResourceV1PathPatch6Async(
                                    resource: resource,
                                    path: path,
                                    xAi21Key: xAi21Key,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AI21.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}