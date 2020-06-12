using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Song: Content
    {
        public string Band { get; set; }
        public int Year { get; set; }
        public string Album { get; set; }

        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Band}, {Album}, {Year}");
        }
    }
}
