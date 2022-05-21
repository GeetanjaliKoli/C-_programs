using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class Leapyear
    {
        public static void Year(string[] args)
        {
            Console.WriteLine("Enter the year");
            int yearvalue = Convert.ToInt32(Console.ReadLine());

            if (yearvalue % 4 == 0)
            {
                Console.WriteLine("The year " + yearvalue + "is a leap year");
            }
            else
            {
                Console.WriteLine("The year " + yearvalue + " is not a leap year");
            }

        }
    }
}
