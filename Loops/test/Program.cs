using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
                double fac = 1;
            for (int j = i; j >= 1; j--)
            {
                fac = fac * j;
            }
            Console.WriteLine(fac);
          int  x = 2;
            Console.WriteLine(Math.Pow(x, i));

        }
    }
}
