using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

if (openApiDocument.Paths != null)
{
    foreach (var pair in openApiDocument.Paths)
    {
        var operations = pair.Value?.Operations;
        if (operations == null)
        {
            continue;
        }

        foreach (var operation in operations.Values)
        {
            var startTime = operation.Parameters?.FirstOrDefault(x => x.Name == "request_start_time");
            if (startTime != null)
            {
                ((OpenApiSchema)startTime.Schema!).Default = JsonValue.Create("1730898900272");
            }
        }
    }
}

// Remove 'additionalProperties' property from HTTPToolFunctionParameters to avoid
// naming collision with the generated [JsonExtensionData] AdditionalProperties
// TODO: Move this fix to AutoSDK level so all SDKs benefit
if (openApiDocument.Components?.Schemas?.TryGetValue("HTTPToolFunctionParameters", out var httpToolFuncParams) == true
    && httpToolFuncParams is OpenApiSchema httpToolFuncParamsSchema)
{
    httpToolFuncParamsSchema.Properties?.Remove("additionalProperties");
    httpToolFuncParamsSchema.Required?.Remove("additionalProperties");
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
