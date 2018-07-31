using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBlog.Services
{
    public interface IAccountServices
    {
        void Signup(string name, string password);
    }
}
