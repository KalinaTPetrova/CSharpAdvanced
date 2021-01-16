using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                switch (command)
                {
                    case "1":
                        int toAdd = int.Parse(input[1]);
                        numbers.Push(toAdd);
                        break;
                    case "2":
                        if (numbers.Count > 0)
                        {

                        numbers.Pop();
                        }
                        break;
                    case "3":
                        if (numbers.Count > 0)
                        {

                        Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count > 0)
                        {

                        Console.WriteLine(numbers.Min());
                        }
                        break;
                    default:
                        break;
                }
            }
                Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
