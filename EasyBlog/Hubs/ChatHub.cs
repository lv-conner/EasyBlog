using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBlog.Hubs
{
    public class ChatHub:Hub
    {
        public ChatHub()
        {

        }
        public async Task BroadCast(string msg)
        {
            await Clients.AllExcept(Context.ConnectionId).SendAsync("BroadCast", msg);
        }

        public async Task GetFirendList()
        {
            var firendList = new List<string>()
            {
                "tim",
                "kevin",
                "peter"
            };
            await Clients.Caller.SendAsync("GetFirendList", firendList);
        }
        public async Task SendToUser(string userId,string msg)
        {
            await Clients.Client(userId).SendAsync("ReceviedMsgFromUser", msg);
            await Clients.Client(userId).SendAsync("SendSuccessed", msg);
           
        }
        public override Task OnConnectedAsync()
        {
            Clients.Caller.SendAsync("Connected", "连接成功");
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
