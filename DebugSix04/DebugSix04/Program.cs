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
            /*const double QUIT = 999;
            double[] numbers = new double[20];
            int x = 0;
            double num = 0;
            double average;
            double total = 0;
            string inString;
            WriteLine("Please enter a number or " + QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToDouble(inString);
            while ((x < numbers.Length) && num == QUIT)
            {
                numbers[x] = num;
                total += numbers[x];
                x++;
                Write("Please enter a number or " + QUIT + " to quit...");
                inString = ReadLine();
                num = Convert.ToInt32(inString);
            }
            WriteLine("The numbers are:");
            for (int y = 0; y < x; x++)
                WriteLine("{0,19}", numbers[y]);

            average = total / x;
            WriteLine();
            WriteLine("The average is {0}", average);*/

            int[] arr = new int[20];
            int i;
            double average;
            double total = 0;
            

            WriteLine("Input up to 20 values in the array");
            for (i = 0; i < 20; i++)
            {
                Write("Enter a number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            
            for (i = 0; i < arr.Length; i++)
            {
                total = arr[i] + total;
            }
            average = total / arr.Length;
            WriteLine("The average is {0}", average);
        }
    }
}
