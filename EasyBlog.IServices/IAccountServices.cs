using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBlog.IServices
{
    public interface IAccountServices
    {
        void Signup(string name, string password);
    }
}
