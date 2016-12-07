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
            string[] matSize = Console.ReadLine().Split();
            int n = int.Parse(matSize[0]);
            int m = int.Parse(matSize[1]);

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;
           for (int f = 0; f <n; f++)
            {
                for (int g = 0; g < m; g++)
                {
                    if ((f+3 <= n) && (g+3<=m))
                    {
                        sum = matrix[f, g] + matrix[f + 1, g] + matrix[f + 2, g] + matrix[f, g + 1] + matrix[f + 1, g + 1] + matrix[f + 2, g + 1] + matrix[f, g + 2] + matrix[f + 1, g + 2] + matrix[f + 2, g + 2];
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
                
            }
            Console.WriteLine(maxSum);

        }
    }
}
