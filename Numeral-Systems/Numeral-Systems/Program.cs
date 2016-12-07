using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_Systems
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> binNum = new Stack<int>();
            while (n > 0)
            {
                int rem = n % 2;
                binNum.Push(rem);
                n = n / 2;

            }

            foreach (var digit in binNum)
            {
                Console.Write(digit);
            }
        }
    }
}
