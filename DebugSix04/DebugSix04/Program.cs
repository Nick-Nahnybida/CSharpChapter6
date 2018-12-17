using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugSix04
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int QUIT = 999;
            int[] numbers = new int[20];
            int x = 0;
            int num;
            double average;
            double total = 0;
            string inString;
            Write("Please enter a number or " +
               QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);
            while ((x < numbers.Length) && num != QUIT)
            {
                numbers[x] = num;
                total += numbers[x];
                ++x;
                Write("Please enter a number or " +
                   QUIT + " to quit...");
                inString = ReadLine();
                num = Convert.ToInt32(inString);
            }
            WriteLine("The numbers are:");
            for (int y = 0; y < x; ++y)
                Write("{0,6}", numbers[y]);
            average = total / x;
            WriteLine();
            WriteLine("The average is {0}", average);
        }
    }
}
