using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:C2}", 123.456);
            //Output: 123,46 лв.
            Console.WriteLine("{0:D6}", -1234);
            //Output: -001234
            Console.WriteLine("{0:E2}", 123);
            //Output: 1,23Е+002
            Console.WriteLine("{0:F2}", -123.456);
            //Output: -123,46
            Console.WriteLine("{0:N2}", 1234567.8);
            //Output: 1 234 567,80
            Console.WriteLine("{0:P}", 0.456);
            //Output: 45,60 %
            Console.WriteLine("{0:X}", 254);
            //Output: FE
        }
    }
}
