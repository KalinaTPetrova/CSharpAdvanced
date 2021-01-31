using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool>Valid  = (word,num) => word.ToCharArray().Select(ch => (int)ch).Sum() >= num;

            Func<List<string>, int, Func<string, int, bool>, string> firstValid = (arr, num, func) => arr.FirstOrDefault(s=>func(s, num));

            var output = firstValid(names, n, Valid);
            Console.WriteLine(output);
                
           


        }
        
    }
}
