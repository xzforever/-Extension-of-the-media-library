using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Book: Content
    {
        public Book(string title, string description,string autor, int pageNum)
            :base(title, description)
        {
            Autor = autor;
            PageNum = pageNum;
        }
        public string Autor { get; set; }
        public int PageNum { get; set; }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"Autor: {Autor}, Number of pages: {PageNum}");
        }
    }
}
