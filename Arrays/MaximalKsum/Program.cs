using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int sum = 0;
            int counter = 0;
            for (int j = arr.Length - 1; j >=0; j--)
            {
                if (counter < k)
                {
                    sum = sum + arr[j];
                    counter++;
                }
                else
                {
                    break;
                }
                
            }
           // Console.WriteLine(string.Join("",arr));
            Console.WriteLine(sum);
        }
    }
}
