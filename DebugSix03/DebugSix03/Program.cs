﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugSix03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
            int x;
            string entryString;

            WriteLine("What book are you looking for? ");
            entryString = Convert.ToString(ReadLine());
            x = Array.BinarySearch(books, entryString);
            if (x < 0)
                WriteLine("{0} not found", entryString);
            else
                WriteLine("Yes, we carry {0}", entryString);
        }
    }
}
