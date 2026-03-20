# AI21

[![Nuget package](https://img.shields.io/nuget/vpre/AI21)](https://www.nuget.org/packages/AI21/)
[![dotnet](https://github.com/tryAGI/AI21/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/AI21/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/AI21)](https://github.com/tryAGI/AI21/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAPI specification](https://api.ai21.com/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` support

### Usage
```csharp
using AI21;

usung var api = new Ai21Client(apiKey);

await api.Chat.V1J2UltraChatAsync(
    messages:
    [
        new ChatMessage
        {
            Text = "Hello",
            Role = RoleType.User,
        }
    ],
    system: string.Empty,
    cancellationToken: CancellationToken.None);
```

### Microsoft.Extensions.AI

The SDK implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient):
```csharp
using AI21;
using Microsoft.Extensions.AI;

IChatClient chatClient = new Ai21Client(apiKey);

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello!")],
    new ChatOptions { ModelId = "jamba-1.5-mini" });

Console.WriteLine(response.Text);
```

<!-- EXAMPLES:START -->
### Chat Client Five Random Words Streaming
```csharp
using var client = GetAuthorizedClient();

IChatClient chatClient = client;
var updates = chatClient.GetStreamingResponseAsync(
    [
        new ChatMessage(ChatRole.User, "Generate 5 random words.")
    ],
    new ChatOptions
    {
        ModelId = "jamba-large",
    });

var deltas = new List<string>();
await foreach (var update in updates)
{
    if (!string.IsNullOrWhiteSpace(update.Text))
    {
        deltas.Add(update.Text);
    }
}
```

### Chat Client Five Random Words
```csharp
using var client = GetAuthorizedClient();

IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User, "Generate 5 random words.")
    ],
    new ChatOptions
    {
        ModelId = "jamba-large",
    });
```

### Chat Client Get Service Returns Chat Client Metadata
```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var metadata = chatClient.GetService<ChatClientMetadata>();
```

### Chat Client Get Service Returns Null For Unknown Key
```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var result = chatClient.GetService<ChatClientMetadata>(serviceKey: "unknown");
```

### Chat Client Get Service Returns Self
```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var self = chatClient.GetService<Ai21Client>();
```

### Chat Client Tool Calling Multi Turn
```csharp
using var client = GetAuthorizedClient();
IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What's the weather in Seattle?"),
};

var options = new ChatOptions
{
    ModelId = "jamba-large",
    Tools = [getWeatherTool],
};

// First turn: model should call the tool
var response = await chatClient.GetResponseAsync(messages, options);

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .FirstOrDefault();

// Add assistant response with tool call and tool result
messages.AddRange(response.Messages);

var toolResult = await getWeatherTool.InvokeAsync(
    functionCall!.Arguments is { } args ? new AIFunctionArguments(args) : null);

messages.Add(new ChatMessage(ChatRole.Tool,
[
    new FunctionResultContent(functionCall.CallId, toolResult),
]));

// Second turn: model should respond with the weather info
var finalResponse = await chatClient.GetResponseAsync(messages, options);
```

### Chat Client Tool Calling Single Turn
```csharp
using var client = GetAuthorizedClient();
IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "What's the weather in Seattle?")],
    new ChatOptions
    {
        ModelId = "jamba-large",
        Tools = [getWeatherTool],
    });

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .FirstOrDefault();
```

### Chat Client Tool Calling Streaming
```csharp
using var client = GetAuthorizedClient();
IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var updates = chatClient.GetStreamingResponseAsync(
    [new ChatMessage(ChatRole.User, "What's the weather in Seattle?")],
    new ChatOptions
    {
        ModelId = "jamba-large",
        Tools = [getWeatherTool],
    });

var functionCalls = new List<FunctionCallContent>();
await foreach (var update in updates)
{
    functionCalls.AddRange(update.Contents.OfType<FunctionCallContent>());
}
```

### Test
```csharp
using var api = GetAuthorizedClient();

// await api.Completion.V1J2UltraCompleteAsync(
//     messages:
//     [
//         new ChatMessage
//         {
//             Text = "Hello",
//             Role = RoleType.User,
//         }
//     ],
//     system: string.Empty,
//     cancellationToken: CancellationToken.None);
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/AI21/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/AI21/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
