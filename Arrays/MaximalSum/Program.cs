using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];


            for (int k = 0; k < n; k++)
            {
                arr[k] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int temp = 0;
            if (n == 4)
            {
                sum = arr[0] + arr[1] + arr[2] + arr[3];
                Console.WriteLine(sum);
            }
            else
            {


                for (int j = 0; j < arr.Length - 3; j++)
                {
                    sum = sum + arr[j] + arr[j + 1] + arr[j + 2] + arr[j + 3];
                    if (temp < sum)
                    {
                        temp = sum;
                    }
                    sum = 0;
                }
                Console.WriteLine(temp);

            }
            
        }
    }
}
