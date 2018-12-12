using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 200, 200, 180, 180, 160, 160, 160, 145 };
            int days;
            int nightPrice = 1;
            int total;

            WriteLine("Please enter the number of nights you plan on staying.");
            days = Convert.ToInt32(ReadLine());

            if (days < 8)
            {
                nightPrice = arr[days];
            }
            else if (days >= 8)
            {
                nightPrice = arr[8];
            }

            total = days * nightPrice;

            WriteLine("You plan on staying {0} nights", days);
            WriteLine("Your total will be "+ total.ToString("C") + " at " + nightPrice.ToString("C") + " a night");



        }
    }
}
