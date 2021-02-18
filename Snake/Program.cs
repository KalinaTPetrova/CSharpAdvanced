using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int positionRow = 0;
            int positionCol = 0;


            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        positionRow = row;
                        positionCol = col;
                    }
                }

            }

            string command = Console.ReadLine();
            int food = 0;
            while (true)
            {

                matrix[positionRow, positionCol] = '.';
                positionRow = MoveRow(positionRow, command);
                positionCol = MoveCol(positionCol, command);

                if (!IsPositionValid(positionRow, positionCol, n, n))
                {

                    Console.WriteLine("Game over!");
                    break;
                }

                
                if (matrix[positionRow, positionCol] == '*')
                {
                    food++;
                    
                }

                if (food >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    matrix[positionRow, positionCol] = 'S';

                    break;
                }

                if (matrix[positionRow, positionCol] == 'B')
                {
                    matrix[positionRow, positionCol] = '.';
                    for (int row = 0; row < n; row++)
                    {

                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'B')
                            {

                                positionRow = row;
                                positionCol = col;

                            }
                        }


                    }

                }
                matrix[positionRow, positionCol] = 'S';


                command = Console.ReadLine();


            }

            Console.WriteLine($"Food eaten: {food}");


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
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
