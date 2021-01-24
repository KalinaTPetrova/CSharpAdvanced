using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];
            string[,] matrix = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = input[j];


                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs.Length == 5)

                {
                    int row1 = int.Parse(cmdArgs[1]);
                    int col1 = int.Parse(cmdArgs[2]);
                    int row2 = int.Parse(cmdArgs[3]);
                    int col2 = int.Parse(cmdArgs[4]);




                    if (cmdArgs[0] == "swap" && (row1 >= 0 && row1 < n) || (col1 >= 0 && col1 < m) && (row2 >= 0 && row2 < n) && (col2 >= 0 && col2 < m))
                    {

                        string toSwap = matrix[row2, col2];
                        matrix[row2, col2] = matrix[row1, col1];
                        matrix[row1, col1] = toSwap;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");

                }

                command = Console.ReadLine();
            }
        }
    }
}
