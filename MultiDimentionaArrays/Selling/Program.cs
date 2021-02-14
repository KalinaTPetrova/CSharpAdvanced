using System;

namespace Selling
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
            int rent = 0;
            bool rentEnough = false;
            while (true)
            {
                matrix[positionRow, positionCol] = '-';
                positionRow = MoveRow(positionRow, command);
                positionCol = MoveCol(positionCol, command);

                if (!IsPositionValid(positionRow, positionCol, n, n))
                {
                    Console.WriteLine($"Bad news, you are out of the bakery.");
                    break;
                }
                if (matrix[positionRow, positionCol] != '-' && matrix[positionRow, positionCol] != 'O'&&matrix[positionRow,positionCol]!='S')
                {
                    
                    
                    
                    rent += int.Parse((matrix[positionRow, positionCol]).ToString());
                    
                    if (rent >= 50)
                    {
                    matrix[positionRow, positionCol] = 'S';
                        rentEnough = true; break; }
                }

                if (matrix[positionRow, positionCol] == 'O')
                {
                     matrix[positionRow, positionCol] = '-';
                    for (int row = 0; row < n; row++)
                    {

                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'O')
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
            if (rentEnough)
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {rent}");

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