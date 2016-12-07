using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFeathers
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            double avg =  f / b;

            if (b % 2 == 0)
            {
               
                Console.WriteLine("{0:F4}", avg * 123123123123);
            }
            else
            {
                Console.WriteLine("{0:F4}", avg / 317);
            }

            
        }
    }
}
