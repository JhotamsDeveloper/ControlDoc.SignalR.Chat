﻿using ControlDoc.SignalR.Chat.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace ControlDoc.SignalR.Chat.Server
{
    public class SignalRHub : Hub
    {
        public async Task SendMessageAsync(ChatMessage message, string userName)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, userName);
        }
        public async Task ChatNotificationAsync(string message, string receiverUserId, string senderUserId)
        {
            await Clients.All.SendAsync("ReceiveChatNotification", message, receiverUserId, senderUserId);
        }
    }
}
