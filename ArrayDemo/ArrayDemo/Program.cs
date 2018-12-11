using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int i;
            int choice;
            int elementChoice;

            Write("\n\nRead and Print elements of an array:\n");
            Write("----------------------------------------\n");
            Write("Input 8 elements in the array");

            for (i = 0; i < 8; i++)
            {
                Write("Enter a number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Choose display option");
            choice = Convert.ToInt32(ReadLine());
            if (choice == 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    WriteLine("Number entered was " + arr[j]);
                }
            }
            else if (choice == 2)
            {
                for (int j = 7; j >= 0; j--)
                {
                    WriteLine("Numbers entered backwards are " + arr[j]);
                }
            }
            else if (choice == 3)
            {
                WriteLine("Pick a number 0-7 inclusive");
                elementChoice = Convert.ToInt32(ReadLine());
                WriteLine("Selected number is " + arr[elementChoice]);
            }
            ReadLine();
            
        }
    }
}
