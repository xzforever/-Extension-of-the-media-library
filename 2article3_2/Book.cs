using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Book: Content
    {
        private string _autor;
        private int _pageNum;
        public Book(string title, string description,string autor, int pageNum)
            :base(title, description)
        {
            Autor = autor;
            PageNum = pageNum;
        }
        public string Autor 
        {
            get
            {
                return _autor;
            }
            set
            {
                if (value == "") _autor = "-";
                else Autor = _autor;
            }
        }
        public int PageNum 
        {
            get
            {
                return _pageNum;
            }
            set
            {
                if (value == 0) _pageNum = 342;
                else if (value < 5) _pageNum = 342;
                else if (value > 9000) _pageNum = 342;
                else PageNum = _pageNum;
            }
        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"Autor: {Autor}, Number of pages: {PageNum}");
        }
    }
}
