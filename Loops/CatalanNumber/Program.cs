using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dn = 2 * n;
            int nOne = n + 1;
            System.Numerics.BigInteger dnFac = 1;
            System.Numerics.BigInteger noneFac = 1;
            System.Numerics.BigInteger nFac = 1;
            for (int f = 1; f <= dn; f++)
            {
                dnFac = dnFac * f;
            }
            for (int i = 1; i <= nOne; i++)
            {
                noneFac = noneFac * i;
            }
            for (int j = 1; j <= n; j++)
            {
                nFac = nFac * j;
            }
            System.Numerics.BigInteger cn = dnFac / (noneFac * nFac);
            Console.WriteLine(cn);
        }
    }
}
