using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int average;
            int i;
            int j;
            int[] temperature = new int[7];
            int total = 0;
            WriteLine("Input the temperatures for the next 7 days");
            for (i = 0; i < temperature.Length; i++)
            {
                j = i + 1;
                Write("Enter temperature " + j + " <<< ");
                temperature[i] = Convert.ToInt32(ReadLine());
                total = temperature[i] + total;
            }
            average = total/ temperature.Length;
            for (i = 0; i < 7; i++)
            {
                j = i + 1;
                WriteLine("Temperature is " + j + " is " + temperature[i] + ", and is " + Math.Abs(temperature[i] - average) + " degrees away from the average.");
            }
        }
    }
}
