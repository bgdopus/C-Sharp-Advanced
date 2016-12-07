using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            try
            {
               double p =  double.Parse(n);
                if (p <= 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else {
                    Console.WriteLine("{0:F3}", Math.Sqrt(p));
                }
            }
            catch(FormatException)
            {
               
                Console.WriteLine("Invalid number");
            }       
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
