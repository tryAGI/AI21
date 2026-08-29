#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class UpdateConfigGatewaySettingsConfigsConfigIdPutCommandApiCommand
{
    private static Argument<string> ConfigId { get; } = new(
        name: @"config-id")
    {
        Description = @"",
    };

    private static Option<object?> Overrides { get; } = new(
        name: @"--overrides")
    {
        Description = @"",
    };
    private static readonly ConfigProfileUpdateOptionSet ConfigProfileUpdateOptionSetOptions = ConfigProfileUpdateOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.ConfigProfileOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.ConfigProfileOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-config-gateway-settings-configs-config-id-put", @"Update Config");
                        command.Arguments.Add(ConfigId);
                        command.Options.Add(Overrides);                        command.Options.Add(ConfigProfileUpdateOptionSetOptions.NameOption);
                        command.Options.Add(ConfigProfileUpdateOptionSetOptions.DescriptionOption);
                        command.Options.Add(ConfigProfileUpdateOptionSetOptions.Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.ConfigProfileUpdate>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var configId = parseResult.GetRequiredValue(ConfigId);
                        var overrides = CliRuntime.WasSpecified(parseResult, Overrides) ? parseResult.GetValue(Overrides) : (__requestBase is { } __OverridesBaseValue ? __OverridesBaseValue.Overrides : default);                        var name = CliRuntime.WasSpecified(parseResult, ConfigProfileUpdateOptionSetOptions.NameOption) ? parseResult.GetValue(ConfigProfileUpdateOptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, ConfigProfileUpdateOptionSetOptions.DescriptionOption) ? parseResult.GetValue(ConfigProfileUpdateOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, ConfigProfileUpdateOptionSetOptions.Enabled) ? parseResult.GetValue(ConfigProfileUpdateOptionSetOptions.Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateConfigGatewaySettingsConfigsConfigIdPutAsync(
                                    configId: configId,
                                    overrides: overrides,
                                    name: name,
                                    description: description,
                                    enabled: enabled,
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