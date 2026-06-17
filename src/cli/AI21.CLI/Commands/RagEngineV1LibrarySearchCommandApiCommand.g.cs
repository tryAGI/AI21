#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class RagEngineV1LibrarySearchCommandApiCommand
{
    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"",
        Required = true,
    };

    private static Option<int?> MaxSegments { get; } = new(
        name: @"--max-segments")
    {
        Description = @"",
    };

    private static Option<string?> Path { get; } = new(
        name: @"--path")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Labels { get; } = new(
        name: @"--labels")
    {
        Description = @"",
    };

    private static Option<global::AI21.QueryFilter?> LabelsFilter { get; } = new(
        name: @"--labels-filter")
    {
        Description = @"",
    };

    private static Option<global::AI21.LibrarySearchRequestLabelsFilterMode?> LabelsFilterMode { get; } = new(
        name: @"--labels-filter-mode")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::System.Guid>?> FileIds { get; } = new(
        name: @"--file-ids")
    {
        Description = @"",
    };

    private static Option<global::AI21.RetrievalStrategy?> RetrievalStrategy { get; } = new(
        name: @"--retrieval-strategy")
    {
        Description = @"",
    };

    private static Option<int?> MaxNeighbors { get; } = new(
        name: @"--max-neighbors")
    {
        Description = @"",
    };

    private static Option<double?> RetrievalSimilarityThreshold { get; } = new(
        name: @"--retrieval-similarity-threshold")
    {
        Description = @"",
    };

    private static Option<double?> HybridSearchAlpha { get; } = new(
        name: @"--hybrid-search-alpha")
    {
        Description = @"",
    };
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
        var command = new Command(@"v1-library-search", @"Search");
                        command.Options.Add(Query);
                        command.Options.Add(MaxSegments);
                        command.Options.Add(Path);
                        command.Options.Add(Labels);
                        command.Options.Add(LabelsFilter);
                        command.Options.Add(LabelsFilterMode);
                        command.Options.Add(FileIds);
                        command.Options.Add(RetrievalStrategy);
                        command.Options.Add(MaxNeighbors);
                        command.Options.Add(RetrievalSimilarityThreshold);
                        command.Options.Add(HybridSearchAlpha);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.LibrarySearchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var query = parseResult.GetRequiredValue(Query);
                        var maxSegments = CliRuntime.WasSpecified(parseResult, MaxSegments) ? parseResult.GetValue(MaxSegments) : (__requestBase is { } __MaxSegmentsBaseValue ? __MaxSegmentsBaseValue.MaxSegments : default);
                        var path = CliRuntime.WasSpecified(parseResult, Path) ? parseResult.GetValue(Path) : (__requestBase is { } __PathBaseValue ? __PathBaseValue.Path : default);
                        var labels = CliRuntime.WasSpecified(parseResult, Labels) ? parseResult.GetValue(Labels) : (__requestBase is { } __LabelsBaseValue ? __LabelsBaseValue.Labels : default);
                        var labelsFilter = CliRuntime.WasSpecified(parseResult, LabelsFilter) ? parseResult.GetValue(LabelsFilter) : (__requestBase is { } __LabelsFilterBaseValue ? __LabelsFilterBaseValue.LabelsFilter : default);
                        var labelsFilterMode = CliRuntime.WasSpecified(parseResult, LabelsFilterMode) ? parseResult.GetValue(LabelsFilterMode) : (__requestBase is { } __LabelsFilterModeBaseValue ? __LabelsFilterModeBaseValue.LabelsFilterMode : default);
                        var fileIds = CliRuntime.WasSpecified(parseResult, FileIds) ? parseResult.GetValue(FileIds) : (__requestBase is { } __FileIdsBaseValue ? __FileIdsBaseValue.FileIds : default);
                        var retrievalStrategy = CliRuntime.WasSpecified(parseResult, RetrievalStrategy) ? parseResult.GetValue(RetrievalStrategy) : (__requestBase is { } __RetrievalStrategyBaseValue ? __RetrievalStrategyBaseValue.RetrievalStrategy : default);
                        var maxNeighbors = CliRuntime.WasSpecified(parseResult, MaxNeighbors) ? parseResult.GetValue(MaxNeighbors) : (__requestBase is { } __MaxNeighborsBaseValue ? __MaxNeighborsBaseValue.MaxNeighbors : default);
                        var retrievalSimilarityThreshold = CliRuntime.WasSpecified(parseResult, RetrievalSimilarityThreshold) ? parseResult.GetValue(RetrievalSimilarityThreshold) : (__requestBase is { } __RetrievalSimilarityThresholdBaseValue ? __RetrievalSimilarityThresholdBaseValue.RetrievalSimilarityThreshold : default);
                        var hybridSearchAlpha = CliRuntime.WasSpecified(parseResult, HybridSearchAlpha) ? parseResult.GetValue(HybridSearchAlpha) : (__requestBase is { } __HybridSearchAlphaBaseValue ? __HybridSearchAlphaBaseValue.HybridSearchAlpha : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RagEngine.V1LibrarySearchAsync(
                                    query: query,
                                    maxSegments: maxSegments,
                                    path: path,
                                    labels: labels,
                                    labelsFilter: labelsFilter,
                                    labelsFilterMode: labelsFilterMode,
                                    fileIds: fileIds,
                                    retrievalStrategy: retrievalStrategy,
                                    maxNeighbors: maxNeighbors,
                                    retrievalSimilarityThreshold: retrievalSimilarityThreshold,
                                    hybridSearchAlpha: hybridSearchAlpha,
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