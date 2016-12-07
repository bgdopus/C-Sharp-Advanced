using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 | b == 0 | c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int counter = 0;
                if (a < 0)
                {
                    counter++;
                }
                if (b < 0)
                {
                    counter++;
                }
                if (c < 0)
                {
                    counter++;
                }
                switch (counter)
                {
                    case 1:
                        Console.WriteLine("-");
                        break;
                    case 2:
                        Console.WriteLine("+");
                        break;
                    case 3:
                        Console.WriteLine("-");
                        break;
                    default:
                        Console.WriteLine("+");
                        break;
                }
            }
        }
            }
        }
    

