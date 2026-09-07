#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class ListProviderKeysTokenwiseSettingsProviderKeysGetCommandApiCommand
{
    private static Option<string?> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.ProviderKeyOut>, global::AI21.ProviderKeyOut> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.ProviderKeyOut>, global::AI21.ProviderKeyOut> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-provider-keys-tokenwise-settings-provider-keys-get", @"List Provider Keys
The workspace's provider keys, masked.

One endpoint, two shapes, mirroring the BFF: without ``provider`` it lists
every key for the workspace; with one it returns that single key, or 404 if
the workspace has none for it. The union response model is the honest
declaration of that — see ``provider_keys/router.py::list_provider_keys``.

``provider`` is bounded here so an explicitly empty ``?provider=`` fails with
422 at this edge rather than making the round trip (the BFF rejects it too);
omitting it entirely is the list case. It rides through on the forwarded query
string — see ``tokenwise_service._build_gateway_request``.");
                        command.Options.Add(Provider);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var provider = parseResult.GetValue(Provider);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ListProviderKeysTokenwiseSettingsProviderKeysGetAsync(
                                    provider: provider,
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