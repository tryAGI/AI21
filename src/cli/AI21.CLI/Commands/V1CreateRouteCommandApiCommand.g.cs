#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class V1CreateRouteCommandApiCommand
{
    private static Argument<string> AssistantId { get; } = new(
        name: @"assistant-id")
    {
        Description = @"",
    };

    private static Option<string> PlanId { get; } = new(
        name: @"--plan-id")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>> Examples { get; } = new(
        name: @"--examples")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.AssistantRoute value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.AssistantRoute value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-create-route", @"Create Route");
                        command.Arguments.Add(AssistantId);
                        command.Options.Add(PlanId);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Examples);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var assistantId = parseResult.GetRequiredValue(AssistantId);
                        var planId = parseResult.GetRequiredValue(PlanId);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var description = parseResult.GetRequiredValue(DescriptionOption);
                        var examples = parseResult.GetRequiredValue(Examples);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.V1CreateRouteAsync(
                                    assistantId: assistantId,
                                    planId: planId,
                                    name: name,
                                    description: description,
                                    examples: examples,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AI21.SourceGenerationContext.Default,
                                        @"Examples",
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