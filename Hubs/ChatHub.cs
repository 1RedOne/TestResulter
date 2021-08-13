using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestResultChat;

namespace NetLearner.SignalRPoll.Hubs
{
    public class ChatHub : Hub
    {
        public async Task<bool> SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            return true;
        }

        public async Task<bool> SendMessage2(string user, MessageContent results)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, results);
            return true;
        }

        //public void SendMessageStatic(string user, string message)
        //{
        //    var t = Clients.All.SendAsync("ReceiveMessage", user, message).Result;
        //}
    }
}