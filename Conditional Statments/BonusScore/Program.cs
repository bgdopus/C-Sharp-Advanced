using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(n*10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(n*100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(n*1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}
