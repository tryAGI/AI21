#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class LibraryManagementV1LibraryManagement2CommandApiCommand
{
    private static Argument<global::System.Guid> FileId { get; } = new(
        name: @"file-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.FileResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.FileResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-library-management2", @"Get File By Id
Retrieve a list of documents in the user's library. Optionally specify a
filter to find only files with matching labels or paths. This method
returns only metadata about files; to download a file, call
`GET .../files/{file_id}/download`

When specifying qualifiers with your request, only files that match
_all_ qualifiers will be returns. So, for example, if you specify
`label='financial'` and `status='UPLOADED'`, only files with the label
""financial"" AND status UPLOADED will be returned.");
                        command.Arguments.Add(FileId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fileId = parseResult.GetRequiredValue(FileId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LibraryManagement.V1LibraryManagement2Async(
                                    fileId: fileId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AI21.SourceGenerationContext.Default,
                                        @"Labels",
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