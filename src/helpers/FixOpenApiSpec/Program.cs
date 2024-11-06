using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOJson = await File.ReadAllTextAsync(path);

// yamlOJson = yamlOJson
//     .Replace(",\"/studio/v1/custom-model/{model_pid}\":{\"delete\":{\"tags\":[\"custom-models\"],\"summary\":\"Delete Model\",\"operationId\":\"v1_delete_custom_model\",\"parameters\":[{\"required\":true,\"schema\":{\"type\":\"string\",\"title\":\"Model Pid\"},\"name\":\"model_pid\",\"in\":\"path\"}],\"responses\":{\"200\":{\"description\":\"Successful Response\",\"content\":{\"application/json\":{\"schema\":{}}}},\"422\":{\"description\":\"Validation Error\",\"content\":{\"application/json\":{\"schema\":{\"$ref\":\"#/components/schemas/HTTPValidationError\"}}}}}}}", string.Empty)
//     ;

if (OpenApi31Support.IsOpenApi31(yamlOJson))
{
    yamlOJson = OpenApi31Support.ConvertToOpenApi30(yamlOJson);
}

var openApiDocument = new OpenApiStringReader().Read(yamlOJson, out var diagnostics);

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

yamlOJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    //Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOJson);
