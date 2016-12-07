using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //string line = Console.ReadLine();
            string line = "111001";
            string[] numArr = line.Split(' ');
            int[] numbers = Array.ConvertAll(numArr, int.Parse);
            int pow = 0;
            int dec = 0;
            for (int i = numbers.Length; i >= 0; i--)
            {

            }
        }
    }
}
