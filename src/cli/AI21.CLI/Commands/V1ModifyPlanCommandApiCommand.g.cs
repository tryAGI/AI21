#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class V1ModifyPlanCommandApiCommand
{
    private static Argument<string> PlanId { get; } = new(
        name: @"plan-id")
    {
        Description = @"",
    };

    private static Argument<string> AssistantId { get; } = new(
        name: @"assistant-id")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<object>?> Schemas { get; } = new(
        name: @"--schemas")
    {
        Description = @"",
    };
    private static readonly CreatePlanPayloadOptionSet CreatePlanPayloadOptionSetOptions = CreatePlanPayloadOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.Plan value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.Plan value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-modify-plan", @"Modify Plan");
                        command.Arguments.Add(PlanId);
                        command.Arguments.Add(AssistantId);
                        command.Options.Add(Schemas);                        command.Options.Add(CreatePlanPayloadOptionSetOptions.Code);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.CreatePlanPayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var planId = parseResult.GetRequiredValue(PlanId);
                        var assistantId = parseResult.GetRequiredValue(AssistantId);
                        var schemas = CliRuntime.WasSpecified(parseResult, Schemas) ? parseResult.GetValue(Schemas) : (__requestBase is { } __SchemasBaseValue ? __SchemasBaseValue.Schemas : default);                        var code = parseResult.GetRequiredValue(CreatePlanPayloadOptionSetOptions.Code);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.V1ModifyPlanAsync(
                                    planId: planId,
                                    assistantId: assistantId,
                                    schemas: schemas,
                                    code: code,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AI21.SourceGenerationContext.Default,
                                        @"Schemas",
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