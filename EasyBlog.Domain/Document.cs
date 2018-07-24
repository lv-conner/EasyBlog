using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBlog.Domain
{
    public class Document: EntiyBase
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int Version { get; set; }
        public string PreviousVersionId { get; set; }
    }
}
