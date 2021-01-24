using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];
            string input = Console.ReadLine();
            int counter = 0;
            int capacity = rows * cols;
            Queue<char> snake = new Queue<char>();
            for (int i = 0; i < input.Length; i++)
            {
                snake.Enqueue(input[i]);
                counter++;
                if (counter == capacity)
                {
                    break;
                }
                if(i==input.Length-1)
                {
                    i = -1;
                }
            }
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
               
                
                if (row % 2 == 0)
                {

                    for (int col = 0; col < cols; col++)
                    {
                        
                        matrix[row, col] = snake.Dequeue();
                        

                    }

                    
                }
                else if(row%2!=0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake.Dequeue();
                        
                    }

                }
              
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
