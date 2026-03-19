/*
order: 70
title: Chat Client Tool Calling Single Turn
slug: chat-client-tool-calling-single-turn
*/

using Microsoft.Extensions.AI;

namespace AI21.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_SingleTurn()
    {
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

        functionCall.Should().NotBeNull();
        functionCall!.Name.Should().Be("GetWeather");
    }
}
