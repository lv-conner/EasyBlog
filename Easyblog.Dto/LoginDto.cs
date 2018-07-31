using System;
using System.Collections.Generic;
using System.Text;

namespace Easyblog.Dto
{
    public class LoginDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
