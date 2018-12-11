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
            Write("\n\nRead and Print elements of an array:\n");
            Write("----------------------------------------\n");
            Write("Input 10 elements in the array");
            for (i = 0; i < 8; i++)
            {
                Write("Enter a number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Choose display option");
            choice = Convert.ToInt32(ReadLine());
            if(choice == 1)
            {
              for (int j = 0; j < arr.Length; j++)
              {
                  WriteLine("Number entered was " + arr[j]);
              }
            }
            else if(choice == 2)
            {
                for (int j = 8; j > arr.Length; j--)
                {
                    WriteLine("Numbers entered backwards are " + arr[j]);
                }
            }
            
        }
    }
}
