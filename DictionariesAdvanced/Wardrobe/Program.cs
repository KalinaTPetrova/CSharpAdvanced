using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(new [] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < input.Length; j++)
                {

                    if (!wardrobe[color].ContainsKey(input[j]))
                    {
                        wardrobe[color].Add(input[j], 0);
                    }
                    wardrobe[color][input[j]]++;

                }
            }

            string[] wanted = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {

                    if (color.Key == wanted[0] && item.Key == wanted[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {

                    Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }

            }
        }
    }
}
