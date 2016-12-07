using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestArea
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

            int counter = 1;
            int bigCounter = 1;

            int row = 0;
            int col = 0;

            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    if (matrix[row,col] == matrix[f,g])
                    {
                        counter++;
                    }
                    if (counter > bigCounter)
                    {
                        bigCounter = counter;
                    }
                }
            }
        }
    }
}
