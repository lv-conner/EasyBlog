using EasyBlog.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;
namespace EasyBlog.Services.DefaultServices
{
    public class SignalrBroadcastService : IBroadcastService
    {
        public Task BroadcastMessage(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
