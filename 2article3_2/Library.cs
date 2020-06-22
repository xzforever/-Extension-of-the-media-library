using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Library : Content
    {
        public Library(string title, string description)
            : base(title, description)
        {

        }
        Content content = new Content(title, description);
        private static string title;
        private static string description;
        List<Content> list = new List<Content>();
        public void Add()
        {
            list.Add(content);
        }
    }
}
