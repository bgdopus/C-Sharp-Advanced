using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[]  arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] wordArr = word.ToCharArray();
            for (int i = 0; i < wordArr.Length ; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (wordArr[i]==arr[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
