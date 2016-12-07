using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSAofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }

            Console.WriteLine("min={0}",list.Min());
            Console.WriteLine("max={0}", list.Max());
            Console.WriteLine("sum={0}", list.Sum());
            Console.WriteLine("avg={0}", list.Average());
        }
    }
}
