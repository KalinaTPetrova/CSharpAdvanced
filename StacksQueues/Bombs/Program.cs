using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBombEffect = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> lastBombCasing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Dictionary<string, int> pastries = new Dictionary<string, int>()
            {
                {"Datura Bombs", 0},
                {"Cherry Bombs", 0 },               
                {"Smoke Decoy Bombs", 0 }

            };

            int sum = 0;

            bool success = false;
            while (firstBombEffect.Count > 0 || lastBombCasing.Count > 0)
            {

                int bomb1 = firstBombEffect.Peek();
                int bomb2 = lastBombCasing.Pop();

                sum = bomb1 + bomb2;


                if (sum == 40)
                {
                    pastries["Datura Bombs"]++;
                    firstBombEffect.Dequeue();

                }
                else if (sum == 60)
                {
                    pastries["Cherry Bombs"]++;
                    firstBombEffect.Dequeue();

                }
                else if (sum == 120)
                {
                    pastries["Smoke Decoy Bombs"]++;
                    firstBombEffect.Dequeue();

                }

                else
                {

                    bomb2 -= 5;
                    lastBombCasing.Push(bomb2);
                    
                }

                if (pastries.All(x => x.Value >= 3))
                {
                    success = true;
                    break;
                }

            }
            if (success)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }
            if (firstBombEffect.Count <= 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", firstBombEffect)}");
            }
            if (lastBombCasing.Count <= 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", lastBombCasing)}");
            }
            foreach (var item in pastries.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
