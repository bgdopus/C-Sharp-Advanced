using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double s = 1;
            double nfac = 1;

            for (int i = 1; i <= n; i++)
            {
                nfac =nfac * i;
                s += nfac / Math.Pow(x, i);
            }

            Console.WriteLine("{0:f5}", s);
        }
    }
}
