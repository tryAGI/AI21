/*
order: 80
title: Chat Client Tool Calling Streaming
slug: chat-client-tool-calling-streaming
*/

using Microsoft.Extensions.AI;

namespace AI21.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_Streaming()
    {
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

        functionCalls.Should().NotBeEmpty();
        functionCalls.First(fc => fc.Name is not null).Name.Should().Be("GetWeather");
    }
}
