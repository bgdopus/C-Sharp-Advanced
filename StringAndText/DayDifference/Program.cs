using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            TimeSpan res = endDate - startDate;
            Console.WriteLine("Distance: {0:%d} day(s)", res);
        }
    }
}
