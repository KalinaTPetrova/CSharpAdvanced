using System;
using System.Linq;

namespace MultiDimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int [n,n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;
            int counter = n - 1;
            for (int i = 0; i < n; i++)
            {
                primarySum += matrix[i, i];
                secondarySum += matrix[i, counter];
                counter--;
            }


           

            Console.WriteLine(Math.Abs(primarySum-secondarySum));
        }
    }
}
