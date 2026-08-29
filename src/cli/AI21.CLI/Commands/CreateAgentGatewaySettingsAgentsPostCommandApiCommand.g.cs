#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class CreateAgentGatewaySettingsAgentsPostCommandApiCommand
{
    private static readonly AgentCreateOptionSet AgentCreateOptionSetOptions = AgentCreateOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.AgentOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.AgentOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-agent-gateway-settings-agents-post", @"Create Agent");
                        command.Options.Add(AgentCreateOptionSetOptions.AgentId);
                        command.Options.Add(AgentCreateOptionSetOptions.Kind);
                        command.Options.Add(AgentCreateOptionSetOptions.NameOption);
                        command.Options.Add(AgentCreateOptionSetOptions.DescriptionOption);
                        command.Options.Add(AgentCreateOptionSetOptions.ConfigId);
                        command.Options.Add(AgentCreateOptionSetOptions.Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.AgentCreate>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);                        var agentId = parseResult.GetRequiredValue(AgentCreateOptionSetOptions.AgentId);
                        var kind = CliRuntime.WasSpecified(parseResult, AgentCreateOptionSetOptions.Kind) ? parseResult.GetValue(AgentCreateOptionSetOptions.Kind) : (__requestBase is { } __KindBaseValue ? __KindBaseValue.Kind : default);
                        var name = CliRuntime.WasSpecified(parseResult, AgentCreateOptionSetOptions.NameOption) ? parseResult.GetValue(AgentCreateOptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, AgentCreateOptionSetOptions.DescriptionOption) ? parseResult.GetValue(AgentCreateOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var configId = CliRuntime.WasSpecified(parseResult, AgentCreateOptionSetOptions.ConfigId) ? parseResult.GetValue(AgentCreateOptionSetOptions.ConfigId) : (__requestBase is { } __ConfigIdBaseValue ? __ConfigIdBaseValue.ConfigId : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, AgentCreateOptionSetOptions.Enabled) ? parseResult.GetValue(AgentCreateOptionSetOptions.Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAgentGatewaySettingsAgentsPostAsync(
                                    agentId: agentId,
                                    kind: kind,
                                    name: name,
                                    description: description,
                                    configId: configId,
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