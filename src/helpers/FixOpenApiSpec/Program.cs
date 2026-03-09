using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

foreach (var pair in openApiDocument.Paths!)
{
    foreach (var (_, operation) in pair.Value.Operations)
    {
        var startTime = operation.Parameters?.FirstOrDefault(x => x.Name == "request_start_time");
        if (startTime != null)
        {
            ((OpenApiSchema)startTime.Schema!).Default = JsonValue.Create("1730898900272");
        }
    }
}

// Set server
openApiDocument.Servers?.Clear();
openApiDocument.Servers?.Add(new OpenApiServer
{
    Url = "https://api.ai21.com/",
});

openApiDocument.Components ??= new OpenApiComponents();
openApiDocument.Components.SecuritySchemes ??= new Dictionary<string, IOpenApiSecurityScheme>();
openApiDocument.Components.SecuritySchemes.Add("Bearer", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
});
openApiDocument.Security =
[
    new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecuritySchemeReference("Bearer", openApiDocument),
            new List<string>()
        }
    }
];

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
