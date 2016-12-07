using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string comm = Console.ReadLine();

            int[,] matrix = new int[n, n];
            int counter = 1;
            int maxRotations = n * n;
            int row = 0;
            int col = 0;
            string direction = "down";
            

            switch (comm)
            {
                case "a":
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matrix[j, i] = counter;
                                counter++;
                            }
                        }
                    }
                    break;
                case "b":
                    {
                        for (int i = 1; i <= maxRotations; i++)
                        {
                            
                            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                            {
                                direction = "up";
                                row--;
                                col++;
                            }
                           
                            if (direction == "up" && row < 0 || matrix[row, col] != 0)
                            {
                                direction = "down";
                                row++;
                                col++;
                            }

                            matrix[row, col] = i;

                            if (direction == "down")
                            {
                                row++;
                            }
                           
                            if (direction == "up")
                            {
                                row--;
                            }
                        }
                    }
                    break;
                case "c":
                    {
                        for (int roww  = n - 1; roww >= 0; roww--)
                        {
                            for (int coll = 0; coll < n - roww; coll++)
                            {
                                matrix[roww + coll, coll] = counter++;
                            }
                        }
                        for (int coll = 1; coll < n; coll++)
                        {
                            for (int roww = 0; roww < n - coll; roww++)
                            {
                                matrix[roww, coll + roww] = counter++;
                            }
                        }


                    }
                    break;
                case "d":
                    {
                        for (int i = 1; i <= maxRotations; i++)
                        {
                            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                            {
                                direction = "up";
                                col--;
                                row--;
                            }
                            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                            {
                                direction = "right";
                                row--;
                                col++;
                            }
                            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                            {
                                direction = "down";
                                col++;
                                row++;
                            }

                            if (direction == "up" && row < 0 || matrix[row, col] != 0)
                            {
                                direction = "left";
                                row++;
                                col--;
                            }

                            matrix[row, col] = i;

                            if (direction == "right")
                            {
                                col++;
                            }
                            if (direction == "down")
                            {
                                row++;
                            }
                            if (direction == "left")
                            {
                                col--;
                            }
                            if (direction == "up")
                            {
                                row--;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j]);

                    if (j + 1 == matrix.GetLength(0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    }

