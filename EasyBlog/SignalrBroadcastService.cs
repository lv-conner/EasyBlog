using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace EasyBlog
{
    public class SignalrBroadcastService<THub> where THub:Hub
    {
        private readonly HubLifetimeManager<THub> _hubManager;
        public SignalrBroadcastService(HubLifetimeManager<THub> hubManager)
        {
            _hubManager = hubManager;
        }
    }
}
