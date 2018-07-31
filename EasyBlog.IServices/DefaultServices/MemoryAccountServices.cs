using EasyBlog.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EasyBlog.Services;

namespace EasyBlog.IServices.DefaultServices
{
    public class MemoryAccountServices : IAccountServices
    {
        private readonly List<Users> _userList = new List<Users>();
        public MemoryAccountServices(IEnumerable<Users> innerUser)
        {
            if(innerUser != null && innerUser.Count() != 0)
            {
                _userList.AddRange(innerUser);
            }
        }
        public void Signup(string name, string password)
        {
            if(_userList.FirstOrDefault(p=>p.Name == name) !=null)
            {
                throw new ArgumentException("已存在");
            }
            else
            {
                _userList.Add(new Users(name, password));
            }
        }
    }
}
