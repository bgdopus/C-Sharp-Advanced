using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 1;
            int maxCount = 0;
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        num = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(num + " ({0} times)", maxCount);

        }

            }
        }

