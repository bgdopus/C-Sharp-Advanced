using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int groups = 0;
            int groupSp = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {
                if (groupSp < arr[j])
                {
                    
                    continue;
                }
                else if (groupSp >= arr[j])
                {
                    groupSp = arr[j];
                    groups++;
                }
                
            }
            Console.WriteLine(groups);
        }
    }
}
