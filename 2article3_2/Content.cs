using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Content
    {
        private string _title;
        private string _description;
        public Content(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value == "") _title = "-";
                else Title = _title;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value == "") _description = "-";
                else Description = _description;
            }
        }
        public void PrintShortInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
        }
    }
}
