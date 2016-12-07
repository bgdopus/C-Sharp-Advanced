using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string sLine = Console.ReadLine();

            switch (str)
            {
                case "integer":
                    int intNum = int.Parse(sLine);
                    Console.WriteLine(intNum+1);
                    break;
                case "real":
                    double realNum = double.Parse(sLine);
                    Console.WriteLine("{0:F2}",realNum + 1);
                    break;
                default:
                    Console.WriteLine(sLine + "*");
                    break;
            }
        }
    }
}
