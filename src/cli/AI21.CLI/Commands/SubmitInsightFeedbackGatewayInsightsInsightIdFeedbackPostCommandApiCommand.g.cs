#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class SubmitInsightFeedbackGatewayInsightsInsightIdFeedbackPostCommandApiCommand
{
    private static Argument<string> InsightId { get; } = new(
        name: @"insight-id")
    {
        Description = @"",
    };
    private static readonly InsightFeedbackInOptionSet InsightFeedbackInOptionSetOptions = InsightFeedbackInOptionSet.Create();
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.InsightOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.InsightOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"submit-insight-feedback-gateway-insights-insight-id-feedback-post", @"Submit Insight Feedback
Record the user's verdict (+ optional comment) on an insight.

Orthogonal to the lifecycle — allowed in every customer-visible state, and
last write wins. The gateway owns the closed verdict set.");
                        command.Arguments.Add(InsightId);                        command.Options.Add(InsightFeedbackInOptionSetOptions.Verdict);
                        command.Options.Add(InsightFeedbackInOptionSetOptions.Comment);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.InsightFeedbackIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var insightId = parseResult.GetRequiredValue(InsightId);                        var verdict = parseResult.GetRequiredValue(InsightFeedbackInOptionSetOptions.Verdict);
                        var comment = CliRuntime.WasSpecified(parseResult, InsightFeedbackInOptionSetOptions.Comment) ? parseResult.GetValue(InsightFeedbackInOptionSetOptions.Comment) : (__requestBase is { } __CommentBaseValue ? __CommentBaseValue.Comment : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubmitInsightFeedbackGatewayInsightsInsightIdFeedbackPostAsync(
                                    insightId: insightId,
                                    verdict: verdict,
                                    comment: comment,
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