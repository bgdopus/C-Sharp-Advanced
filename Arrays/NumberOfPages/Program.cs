using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPages
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int page = 0;
            string line = null;
            int size = 0;
            
            while (size <= d )
            {
                page++;
                line = line + page;
                size = line.Length;

                d = d - size;
                line = null;
            }
            Console.WriteLine(page);
        }
    }
}
