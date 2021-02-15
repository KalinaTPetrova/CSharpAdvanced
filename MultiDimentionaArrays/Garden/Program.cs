using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string input = Console.ReadLine();
            
            Dictionary<int, int> coord = new Dictionary<int, int>();
            while (input != "Bloom Bloom Plow")
            {
            int[] coordinates = input.Split().Select(int.Parse).ToArray();

                 int bloomingRow = coordinates[0];
                 int bloomingCol = coordinates[1];

                if (!IsPositionValid(bloomingRow, bloomingRow, rows, cols))
                {
                    Console.WriteLine($"Invalid coordinates.");
                    input = Console.ReadLine();

                    continue;
                }
                coord.Add(bloomingRow, bloomingCol);

                input = Console.ReadLine();
            }

            foreach (var item in coord)
            {

            Blooming(item.Key, item.Value, matrix);

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]+" ");
                }

                Console.WriteLine();
            }

        }

        public static void Blooming(int cooOne, int cooTwo, int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                matrix[i, cooTwo] += 1;
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[cooOne, i] += 1;
            }
            matrix[cooOne, cooTwo] -= 1;


        }
        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
    }

}
