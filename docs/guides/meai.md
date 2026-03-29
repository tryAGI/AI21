# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The AI21 SDK implements `IChatClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Installation

```bash
dotnet add package tryAGI.AI21
```

## Chat Completions

`Ai21Client` directly implements `IChatClient`, so you can use it with the standard MEAI interface without any adapters.

```csharp
using Microsoft.Extensions.AI;
using AI21;

IChatClient client = new Ai21Client(apiKey: Environment.GetEnvironmentVariable("AI21_API_KEY")!);

var response = await client.GetResponseAsync(
    "What is the capital of France?",
    new ChatOptions { ModelId = "jamba-1.5-mini" });

Console.WriteLine(response.Text);
```

## Streaming

```csharp
using Microsoft.Extensions.AI;
using AI21;

IChatClient client = new Ai21Client(apiKey: Environment.GetEnvironmentVariable("AI21_API_KEY")!);

await foreach (var update in client.GetStreamingResponseAsync(
    "Explain quantum computing in simple terms.",
    new ChatOptions { ModelId = "jamba-1.5-mini" }))
{
    Console.Write(update.Text);
}
```

## Tool Calling

```csharp
using Microsoft.Extensions.AI;
using AI21;

IChatClient client = new Ai21Client(apiKey: Environment.GetEnvironmentVariable("AI21_API_KEY")!);

var tool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 22C.",
    "GetWeather",
    "Gets the current weather for a given location.");

var options = new ChatOptions
{
    ModelId = "jamba-1.5-mini",
    Tools = [tool],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What is the weather in London?"),
};

// The loop handles automatic tool invocation
while (true)
{
    var response = await client.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Reasoning

AI21 Jamba models support reasoning content. When reasoning is present, it is returned as `TextReasoningContent` in the response message.

```csharp
using Microsoft.Extensions.AI;
using AI21;

IChatClient client = new Ai21Client(apiKey: Environment.GetEnvironmentVariable("AI21_API_KEY")!);

var response = await client.GetResponseAsync(
    "If a train leaves at 3pm going 60mph and another leaves at 4pm going 90mph, when do they meet?",
    new ChatOptions { ModelId = "jamba-1.5-mini" });

foreach (var content in response.Messages.SelectMany(m => m.Contents))
{
    switch (content)
    {
        case TextReasoningContent reasoning:
            Console.WriteLine($"Reasoning: {reasoning.Text}");
            break;
        case TextContent text:
            Console.WriteLine($"Answer: {text.Text}");
            break;
    }
}
```

## Dependency Injection

```csharp
using Microsoft.Extensions.AI;
using AI21;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IChatClient>(
    new Ai21Client(apiKey: builder.Configuration["AI21:ApiKey"]!));
```

## Provider Metadata

```csharp
var metadata = client.GetService<ChatClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "Ai21Client"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```
