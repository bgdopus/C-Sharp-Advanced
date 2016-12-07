using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            string words = Console.ReadLine();
            string[] forbidden = words.Split();
            string[] asterix = new string[forbidden.Length];
            string res = null;
            for (int j = 0; j < forbidden.Length; j++)
            {

                for (int f = 0; f < forbidden[j].Length; f++)
                {
                    res += "*";
                }
                asterix[j] = res;
                res = null;
            }

            for (int i = 0; i < forbidden.Length; i++)
            {
                text = text.Replace(forbidden[i], asterix[i]);
            }
            Console.WriteLine(text);
        }
    }
}
