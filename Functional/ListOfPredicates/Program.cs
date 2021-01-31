using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            List <int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers = Enumerable.Range(1, end).ToList();

            Func<int, int, bool> devisible = (num, d) => num % d == 0;

            for (int i = 1; i <=end; i++)
            {
                if (dividers.All(d => devisible(i, d)))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
