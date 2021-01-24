using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

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

            int count = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < m-1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }

                }

            }
            Console.WriteLine(count);

        }
    }
}
