#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class DeleteOrganizationSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemasSchemaNameDeleteCommandApiCommand
{
    private static Argument<string> OrganizationId { get; } = new(
        name: @"organization-id")
    {
        Description = @"",
    };

    private static Argument<string> SchemaName { get; } = new(
        name: @"schema-name")
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
        var command = new Command(@"delete-organization-schema-studio-v1-structured-rag-organizations-organization-id-schemas-schema-name-delete", @"Delete Organization Schema");
                        command.Arguments.Add(OrganizationId);
                        command.Arguments.Add(SchemaName);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var organizationId = parseResult.GetRequiredValue(OrganizationId);
                        var schemaName = parseResult.GetRequiredValue(SchemaName);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeleteOrganizationSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemasSchemaNameDeleteAsync(
                                    organizationId: organizationId,
                                    schemaName: schemaName,
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