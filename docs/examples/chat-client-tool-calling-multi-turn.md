# Chat Client Tool Calling Multi Turn



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

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