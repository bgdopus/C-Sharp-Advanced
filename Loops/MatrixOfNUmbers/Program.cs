using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 0; i < n; i++)
            {
                for (uint j = i; j - i < n; j++)
                {
                    Console.Write("{0} ", j + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
