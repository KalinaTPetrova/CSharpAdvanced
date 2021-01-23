using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            
            {
                if (!result.ContainsKey(text[i]))
                {
                    result.Add(text[i], 0);
                }
                result[text[i]]++;
            }

            foreach (var item in result.OrderBy(x=>x.Key))
            {

                Console.WriteLine($"{item.Key}: {item.Value} time/s");

            }
        }
    }
}
