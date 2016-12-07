using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] hex = input.ToCharArray();

            int power = hex.Length - 1;
            int[] intArr = new int[hex.Length];
            double sum = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '1': intArr[i] = 1;
                        break;
                    case '2':
                        intArr[i] = 2;
                        break;
                    case '3':
                        intArr[i] = 3;
                        break;
                    case '4':
                        intArr[i] = 4;
                        break;
                    case '5':
                        intArr[i] = 5;
                        break;
                    case '6':
                        intArr[i] = 6;
                        break;
                    case '7':
                        intArr[i] = 7;
                        break;
                    case '8':
                        intArr[i] = 8;
                        break;
                    case '9':
                        intArr[i] = 9;
                        break;
                    case 'A':
                        intArr[i] = 10;
                        break;
                    case 'B':
                        intArr[i] = 11;
                        break;
                    case 'C':
                        intArr[i] = 12;
                        break;
                    case 'D':
                        intArr[i] = 13;
                        break;
                    case 'E':
                        intArr[i] = 14;
                        break;
                    case 'F':
                        intArr[i] = 15;
                        break;
                    default:
                        intArr[i] = 0;
                        break;
                }

                
            }
            for (int j = 0; j < intArr.Length; j++)
            {
                sum += (intArr[j]* Math.Pow(16, power));
                power--;
            }

            Console.WriteLine(sum);
        }
    }
}
