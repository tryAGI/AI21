/*
order: 50
title: Chat Client Get Service Returns Self
slug: chat-client-get-service-returns-self
*/

using Microsoft.Extensions.AI;

namespace AI21.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        IChatClient chatClient = client;

        var self = chatClient.GetService<Ai21Client>();

        self.Should().BeSameAs(client);
    }
}
