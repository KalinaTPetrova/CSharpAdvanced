using System;
using System.Collections.Generic;

namespace DictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                userNames.Add(user);

            }

            foreach (var item in userNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}