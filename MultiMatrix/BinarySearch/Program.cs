using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 555, 40, 60, 10, 20, 70 };
            Array.Sort(arr);

            int k = 21;

            int index = -1;
              for (int i = k; i > 0; i--)
             {
                  index = Array.BinarySearch(arr, i);
                 if (index > 0)
                 {
                     Console.WriteLine(arr[index]);
                 }
            }
            
        }
    }
}
