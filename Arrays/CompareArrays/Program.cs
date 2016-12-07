using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int j = 0; j < arr1.Length; j++)
            {
                arr1[j] = int.Parse(Console.ReadLine());
            }
            for (int f = 0; f < arr2.Length; f++)
            {
                arr2[f] = int.Parse(Console.ReadLine());
            }
            bool eq = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    
                    eq = false;
                    break;
                }
                else
                {
                    eq = true;
                    
                }
               
            }
            if (eq == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
