using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
    .Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"")
    .Replace(",\"/studio/v1/custom-model/{model_pid}\":{\"delete\":{\"tags\":[\"custom-models\"],\"summary\":\"Delete Model\",\"operationId\":\"v1_delete_custom_model\",\"parameters\":[{\"required\":true,\"schema\":{\"type\":\"string\",\"title\":\"Model Pid\"},\"name\":\"model_pid\",\"in\":\"path\"}],\"responses\":{\"200\":{\"description\":\"Successful Response\",\"content\":{\"application/json\":{\"schema\":{}}}},\"422\":{\"description\":\"Validation Error\",\"content\":{\"application/json\":{\"schema\":{\"$ref\":\"#/components/schemas/HTTPValidationError\"}}}}}}}", string.Empty)
    ;
var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

// Set server
openApiDocument.Servers.Add(new OpenApiServer
{
    Url = "https://api.ai21.com/",
});

openApiDocument.Components.SecuritySchemes.Add("Bearer", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
});
openApiDocument.SecurityRequirements.Add(new OpenApiSecurityRequirement
{
    [new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Id = "Bearer",
            Type = ReferenceType.SecurityScheme
        }
    }] = new List<string>(),
});

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;