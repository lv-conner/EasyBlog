using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBlog.Domain
{
    public class EntiyBase
    {
        public EntiyBase()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; protected set; }
    }
}
