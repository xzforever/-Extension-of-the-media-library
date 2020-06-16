using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Photo : Content
    {
        public Photo(string title, string description, int height, int width)
            :base(title, description)
        {
            Height = height;
            Width = width;
        }
        public int Height { get; set; }
        public int Width { get; set; }

        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Height} x {Width}");
        }
    }
}
