using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            string[] numArr = line.Split(' ');
            int[] numbers = Array.ConvertAll(numArr, int.Parse);

            int oddP = 1;
            int evenP = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenP = evenP * numbers[i];
                }
                else
                {
                    oddP = oddP * numbers[i];
                }

               
            }
            if (oddP == evenP)
            {
                Console.WriteLine("yes {0}", oddP);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddP, evenP);
            }
        }
    }
}
