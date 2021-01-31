using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> predicate = name => name.Length <= n;

            Func<List<string>, Predicate<string>, List<string>> result = (ns, pred) =>
                 {
                     List<string> newNames = new List<string>();
                     foreach (var item in ns)
                     {
                         if (pred(item))
                         {
                             newNames.Add(item);
 
                         }
                     }

                     return newNames;
                 };

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine,x));
            print(result(names, predicate));
        }
    }
}
