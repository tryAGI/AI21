#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class ProxyV1GatewayV1PathGet5CommandApiCommand
{
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


    public static Command Create()
    {
        var command = new Command(@"proxy-v1-gateway-v1-path-get5", @"Proxy V1
Catch-all for the Anthropic-compatible surface (``/v1/messages``, etc.).

Gated on a Tokenwise subscription (OPSS-55); the A/B ``/on`` and ``/off`` arms are
intentionally left ungated.");
                        command.Arguments.Add(Path);
                        command.Options.Add(XAi21Key);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var path = parseResult.GetRequiredValue(Path);
                        var xAi21Key = parseResult.GetValue(XAi21Key);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ProxyV1GatewayV1PathGet5Async(
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
        return command;
    }
}