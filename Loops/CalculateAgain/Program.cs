using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double kfac = 1;
            double nfac = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    kfac = kfac * i;
                }
                nfac = nfac * i;
                
                
            }
            Console.WriteLine(nfac/kfac);
        }
    }
}
