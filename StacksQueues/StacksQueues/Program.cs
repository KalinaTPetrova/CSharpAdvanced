﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];
            Stack<int> numbers = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                
                numbers.Push(input[i]);
            }
            for (int j = 0; j < s; j++)
            {
                numbers.Pop();
            }

            if (numbers.Count > 0)
            {
                if (numbers.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
