using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBlog.Hubs
{
    public class BroadcastHub:Hub<BroadcastClient>
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }

    public interface BroadcastClient
    {
        Task BroadcastMessage(string message);
    }
}
