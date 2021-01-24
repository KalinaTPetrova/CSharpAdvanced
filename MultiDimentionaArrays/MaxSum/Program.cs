using System;
using System.Linq;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = input[j];


                }
            }
           
            int maxSum = int.MinValue;
            int row = -1;
            int col = -1;
            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < m-2; j++)
                {


                    int sum = matrix[i, j];
                    sum += matrix[i, j + 1]; 
                    sum+= matrix[i, j + 2];
                    sum += matrix[i + 1, j];
                    sum += matrix[i + 1, j + 1];
                    sum += matrix[i + 1, j + 2];
                    sum += matrix[i + 2, j];
                    sum += matrix[i + 2, j + 1];
                    sum+= matrix[i + 2, j + 2]; 

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;

                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int k = row; k < row+3; k++)
            {
                for (int l = col; l < col+3; l++)
                {
                    Console.Write(matrix[k,l]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
