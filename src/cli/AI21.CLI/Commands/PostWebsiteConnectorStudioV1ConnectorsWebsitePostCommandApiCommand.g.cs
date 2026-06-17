#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class PostWebsiteConnectorStudioV1ConnectorsWebsitePostCommandApiCommand
{
    private static Option<global::AI21.WebsiteConnectorPayloadType> Type { get; } = new(
        name: @"--type")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>> Value { get; } = new(
        name: @"--value")
    {
        Description = @"",
        Required = true,
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
        var command = new Command(@"post-website-connector-studio-v1-connectors-website-post", @"Post Website Connector");
                        command.Options.Add(Type);
                        command.Options.Add(Value);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var type = parseResult.GetRequiredValue(Type);
                        var value = parseResult.GetRequiredValue(Value);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PostWebsiteConnectorStudioV1ConnectorsWebsitePostAsync(
                                    type: type,
                                    value: value,
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