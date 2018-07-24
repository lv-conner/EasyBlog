using System;

namespace EasyBlog.Domain
{
    public class Users: EntiyBase
    {
        public Users(string name,string password)
        {
            Name = name;
            Password = password;
        }
        public string Name { get; set; }
        public string Password { get; set; }

    }
}
