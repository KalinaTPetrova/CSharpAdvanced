using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            

            Func <List<string>, List<string>> result = x=>x.Select(y => $"Sir {y}").ToList();

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            print(result(names));
        }
    }
}
