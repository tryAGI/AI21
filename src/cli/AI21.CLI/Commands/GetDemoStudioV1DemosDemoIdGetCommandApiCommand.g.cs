#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class GetDemoStudioV1DemosDemoIdGetCommandApiCommand
{
    private static Argument<string> DemoId { get; } = new(
        name: @"demo-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.Demo value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.Demo value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-demo-studio-v1-demos-demo-id-get", @"Get Demo
Get a specific demo by ID.");
                        command.Arguments.Add(DemoId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var demoId = parseResult.GetRequiredValue(DemoId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetDemoStudioV1DemosDemoIdGetAsync(
                                    demoId: demoId,
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