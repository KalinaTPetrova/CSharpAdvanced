﻿using System;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> print = x=>Console.WriteLine(string.Join(Environment.NewLine, x));

            print(input);
        }
    }
}
