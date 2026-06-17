#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class GetDataSourceStatusStudioV1ConnectorsConnectedUsersEntityIdDataSourcesDataSourceStatusGetCommandApiCommand
{
    private static Argument<string> EntityId { get; } = new(
        name: @"entity-id")
    {
        Description = @"",
    };

    private static Argument<string> DataSource { get; } = new(
        name: @"data-source")
    {
        Description = @"",
    };

    private static Option<string> ParagonToken { get; } = new(
        name: @"--paragon-token")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.ConnectorsStatus value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.ConnectorsStatus value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-data-source-status-studio-v1-connectors-connected-users-entity-id-data-sources-data-source-status-get", @"Get Data Source Status");
                        command.Arguments.Add(EntityId);
                        command.Arguments.Add(DataSource);
                        command.Options.Add(ParagonToken);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var entityId = parseResult.GetRequiredValue(EntityId);
                        var dataSource = parseResult.GetRequiredValue(DataSource);
                        var paragonToken = parseResult.GetRequiredValue(ParagonToken);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetDataSourceStatusStudioV1ConnectorsConnectedUsersEntityIdDataSourcesDataSourceStatusGetAsync(
                                    entityId: entityId,
                                    dataSource: dataSource,
                                    paragonToken: paragonToken,
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