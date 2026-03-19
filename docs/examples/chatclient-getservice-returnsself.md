# ChatClient.GetService.ReturnsSelf



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var self = chatClient.GetService<Ai21Client>();
```