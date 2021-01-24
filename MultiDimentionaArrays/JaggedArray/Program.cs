using System;
using System.Linq;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][ ];
            for (int row = 0; row < rows; row++)
            {

                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[row] = input;               
               
               
            }

            for (int row = 0; row < rows-1; row++)
            {
                double[] firstArr = matrix[row];
                double[] secondArr = matrix[row + 1];

                if (firstArr.Length == secondArr.Length)
                {
                                      


                    matrix[row] = firstArr.Select(e => e * 2).ToArray();
                    matrix[row+1] = secondArr.Select(e => e * 2).ToArray();

                }
                else
                {
                    matrix[row] = firstArr.Select(e => e / 2).ToArray();
                    matrix[row+1] = secondArr.Select(e => e / 2).ToArray();


                }
            }

            string command = Console.ReadLine(); 
            while(command != "End")
            {
                string[] commandData = command.Split();
                int rowInd = int.Parse(commandData[1]);
                int colInd = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                if (commandData[0] == "Add")
                {
                    bool isValid = rowInd >= 0 && rowInd < rows && colInd >= 0 && colInd < matrix[rowInd].Length;
                    if (!isValid)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    matrix[rowInd][colInd] += value;

                }
                else if (commandData[0] == "Subtract")
                {
                    bool isValid = rowInd >= 0 && rowInd < rows && colInd >= 0 && colInd < matrix[rowInd].Length;
                    if (!isValid)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    matrix[rowInd][colInd] -= value;
                }

                command = Console.ReadLine();

            }

            for (int i = 0; i < rows; i++)
            {
                
                Console.WriteLine(string.Join(" ", matrix[i]));
                

            }
        }
    }
}
