using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            Predicate<int> predicate = m => m % n == 0;

            Func<List<int>, Predicate<int>, List<int>> result = (nums, predicate) =>
           {
               List<int> newNums = new List<int>();

               foreach (var item in nums)
               {
                   if (!predicate(item))
                   {
                       newNums.Add(item);
                   }
               }
               return newNums;
           };
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ",x));

            print(result(numbers, predicate));
        }
    }
}
