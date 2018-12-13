using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZipsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            WriteLine("Please enter your zip code");
            input = Convert.ToInt32(ReadLine());
            displayZips(input);

        }
        static void displayZips(int input)
        {
            int[] zips = { 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 10101 };
            int j = 0;
            do
            {
                bool availableZip = false;
                
                for (int i = 0; i < zips.Length; i++)
                {
                    if (input == zips[i])
                    {
                        availableZip = true;
                    }
                }
                if (availableZip)
                {
                    WriteLine("Your zip code is in our delivery area");
                }
                else
                {
                    WriteLine("Your zip code is not in our delivery area");
                }
                j++;
                
            } while (j != 1);
        }
    }
}
