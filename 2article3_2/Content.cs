using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Content
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public void PrintShortInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
        }
    }
}
