using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] bits = input.ToCharArray();
            int[] nums = new int[bits.Length];

            for (int i = 0; i < bits.Length; i++)
            {
                nums[i] = int.Parse(bits[i].ToString());
            }

            int power = nums.Length - 1;
            double sum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                sum += nums[j] * Math.Pow(2, power);
                power--;
            }

            Console.WriteLine(sum);
        }
    }
}
