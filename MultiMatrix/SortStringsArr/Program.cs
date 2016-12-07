using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStringsArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr =
            {
                "Sofia",
                "Plovdiv",
                "Varnaaaa",
                "Burgass"
            };


            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
