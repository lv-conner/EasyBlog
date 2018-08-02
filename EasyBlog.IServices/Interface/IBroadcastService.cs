using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyBlog.Services.Interface
{
    public interface IBroadcastService
    {
        Task BroadcastMessage(string msg);
    }
}
