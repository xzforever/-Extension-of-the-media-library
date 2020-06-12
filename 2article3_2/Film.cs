﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Film: Content
    {
        public string Director { get; set; }
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
