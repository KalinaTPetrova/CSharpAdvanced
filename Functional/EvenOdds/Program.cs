using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = range[0];
            int end = range[1];


            Func<int, int, List<int>> generateList = (n,m) =>
            {
                List<int> list = new List<int>();

                for (int i = n; i <= m; i++)
                {
                    list.Add(i);
                }
                return list;
            };

            List<int> numbers = generateList(start, end);
            Predicate<int> predicate = n => true;
            string command = Console.ReadLine();

            if(command == "even")
            {
                predicate = n => n % 2 == 0;
            }
            else if(command == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", Where(numbers, predicate)));
           
        }

        public static List<int> Where(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNums = new List<int>();

            foreach (var item in numbers)
            {
                if (predicate(item))
                {
                    newNums.Add(item);
                }
            }
            return newNums;
        }

    }
}
