# ChatClient.ToolCalling.SingleTurn



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

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