﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Film: Content
    {
        private string _director;
        public Film(string title, string description, string director, List<string> actors)
            :base (title, description)
        {
            Director = director;
            Actors = actors;
        }
        public string Director 
        {
            get
            {
                return _director;
            }
            set
            {
                if (value == "") _director = "-";
                else Director = _director;
            }
        }
        public List<string> Actors { get; set; }

        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"Director: {Director}");

            Console.WriteLine("Actors:");
            foreach (string actor in Actors)
            {
                Console.WriteLine(actor);
            }
        }
    }
}
