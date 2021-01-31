using System;
using System.Collections.Generic;
using System.Linq;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            Func<List<int>, int> min = nums =>
            {
                int minNum = int.MaxValue;
                foreach (var item in nums)
                {
                    if (item < minNum)
                    {
                        minNum = item;
                    }
                }

                return minNum;
            };

            Console.WriteLine(min(numbers));
        }
    }
}
