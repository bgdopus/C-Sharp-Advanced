using System;
using System.Linq;

namespace TriangleSurface
{
    class Program
    {
       

        static void Main()
        {
            string inputstr = Console.ReadLine();
            long sum = inputstr.Split(' ').Select(int.Parse).ToArray().Sum(); ;
            Console.WriteLine(sum);

        }
    }
    }

