using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Photo : Content
    {
        private int _height;
        private int _width;
        public Photo(string title, string description, int height, int width)
            :base(title, description)
        {
            Height = height;
            Width = width;
        }
        public int Height 
        {
            get
            {
                return _height;
            }
            set
            {
                if (value == 0) _height = 500;
                else if (value < 1) _height = 500;
                else if (value > 5000) _height = 500;
                else Height = _height;
            }
        }
        public int Width 
        {
            get
            {
                return _width;
            }
            set
            {
                if (value == 0) _width = 500;
                else if (value < 1) _width = 500;
                else if (value > 5000) _width = 500;
                else Width = _width;
            }
        }

        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Height} x {Width}");
        }
    }
}
