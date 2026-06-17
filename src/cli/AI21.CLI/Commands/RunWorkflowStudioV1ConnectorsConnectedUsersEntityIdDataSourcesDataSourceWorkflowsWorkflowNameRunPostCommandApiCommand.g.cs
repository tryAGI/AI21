#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class RunWorkflowStudioV1ConnectorsConnectedUsersEntityIdDataSourcesDataSourceWorkflowsWorkflowNameRunPostCommandApiCommand
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

    private static Argument<string> WorkflowName { get; } = new(
        name: @"workflow-name")
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
        var command = new Command(@"run-workflow-studio-v1-connectors-connected-users-entity-id-data-sources-data-source-workflows-workflow-name-run-post", @"Run Workflow");
                        command.Arguments.Add(EntityId);
                        command.Arguments.Add(DataSource);
                        command.Arguments.Add(WorkflowName);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var entityId = parseResult.GetRequiredValue(EntityId);
                        var dataSource = parseResult.GetRequiredValue(DataSource);
                        var workflowName = parseResult.GetRequiredValue(WorkflowName);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RunWorkflowStudioV1ConnectorsConnectedUsersEntityIdDataSourcesDataSourceWorkflowsWorkflowNameRunPostAsync(
                                    entityId: entityId,
                                    dataSource: dataSource,
                                    workflowName: workflowName,
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