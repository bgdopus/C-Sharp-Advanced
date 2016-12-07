using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToAnyOther
{
    class Program
    {
        const string HexDigits = "0123456789ABCDEF";

        static int HexDigitToDecimalValue(char hexDigit)
        {
            if (char.IsDigit(hexDigit))
            {
                return hexDigit - '0';
            }

            return char.ToUpper(hexDigit) - 'A' + 10;
        }

        public static long HexToDec(string input, int startBase)
        {
            long sum = 0;

            foreach (char hex in input)
            {


                sum = HexDigitToDecimalValue(hex) + sum * startBase;
            }

            return sum;
        }

        public static string DecToHex(long input, int endBase)
        {
            string result = string.Empty;

            do
            {
                long value = input % endBase;
                result = HexDigits[(int)value] + result;
                input /= endBase;

            } while (input != 0);

            return result;
        }



        static void Main()
        {
            int fromBase = int.Parse(Console.ReadLine());
            string inputStr = Console.ReadLine();
            int toBase = int.Parse(Console.ReadLine());
            long decNum = HexToDec(inputStr, fromBase);
            string result = DecToHex(decNum, toBase);
            Console.WriteLine(result);


        }
    }
}