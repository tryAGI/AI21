#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class GetOutputExplanationStudioV1ExecutionsExecutionIdExplanationsOutputGetCommandApiCommand
{
    private static Argument<string> ExecutionId { get; } = new(
        name: @"execution-id")
    {
        Description = @"",
    };

    private static Option<bool?> ForceRegenerate { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--force-regenerate",
        description: @"");

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
        var command = new Command(@"get-output-explanation-studio-v1-executions-execution-id-explanations-output-get", @"Get Output Explanation
Get output explanation for an execution (cached or generated).
Set force_regenerate=True to regenerate even if cached.");
                        command.Arguments.Add(ExecutionId);
                        command.Options.Add(ForceRegenerate);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var executionId = parseResult.GetRequiredValue(ExecutionId);
                        var forceRegenerate = parseResult.GetValue(ForceRegenerate);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetOutputExplanationStudioV1ExecutionsExecutionIdExplanationsOutputGetAsync(
                                    executionId: executionId,
                                    forceRegenerate: forceRegenerate,
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