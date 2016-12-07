using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void LeapYearCheck(int year)
        {
            bool isLeapYear = ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0));

            if (isLeapYear)
            {
                Console.WriteLine("Leap");
            }
            else
                Console.WriteLine("Common");
        }
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            LeapYearCheck(year);
        }
    }
}
