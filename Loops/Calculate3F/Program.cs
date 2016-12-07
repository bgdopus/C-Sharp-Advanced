using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate3F
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
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
            double nk = n - k;
            double nkfac = 1;
            for (int f = 1; f <= nk; f++)
            {
                nkfac = nkfac * f;
            }
            Console.WriteLine(nfac /(kfac*nkfac));
        }
    }
}
