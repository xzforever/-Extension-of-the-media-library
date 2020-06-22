using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _2article3_2
{
    class Song: Content
    {
        private string _band;
        private int _year;
        private string _album;
        public Song(string title, string description, string band, int year, string album)
            :base(title, description)
        {
            Band = band;
            Year = year;
            Album = album;
        }
        public string Band 
        {
            get
            {
                return _band;
            }
            set
            {
                if (value == "") _band = "-";
                else value = _band;
            }
        }
        public int Year 
        {
            get
            {
                return  _year;
            }
            set
            {
                if (value == 0) _year = 1990;
                else if (value < 1900) _year = 1990;
                else if (value > 2035) _year = 1990;
                else value = _year;
            }
        }
        public string Album 
        {
            get
            {
                return _album;
            }
            set
            {
                if (value == "") _album = "-";
                else value = _album;
            }
        }

        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Band}, {Album}, {Year}");
        }
    }
}
