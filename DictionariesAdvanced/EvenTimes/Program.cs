using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> collection = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!collection.ContainsKey(num))
                {
                    collection.Add(num, 1);
                }
                else
                {
                    collection[num]++;
                }

               
            }
            foreach (var item in collection)
            {
                if (item.Value % 2 == 0)

                { Console.WriteLine(item.Key); }
            }
        }
    }
}
