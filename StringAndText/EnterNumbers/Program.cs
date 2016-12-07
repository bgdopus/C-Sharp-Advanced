using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numberOfnumbers = 12;
            int start = 1, end = 100;

            var numbers = new int[numberOfnumbers];
            numbers[0] = start; numbers[numberOfnumbers - 1] = end;

            try
            {
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (start >= numbers[i] || numbers[i] >= end)
                    {
                        throw new ArgumentException("out of range");
                    }
                    if (!(numbers[i - 1] < numbers[i]))
                    {
                        throw new ArgumentException("out of range");
                    }
                }
                Console.WriteLine(string.Join(" < ", numbers));
            }
            catch
            {
                Console.WriteLine("Exception");
                return;
            }

        }
    }
}
