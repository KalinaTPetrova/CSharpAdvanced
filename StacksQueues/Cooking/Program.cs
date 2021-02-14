using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int sum = 0;

           
            Dictionary<string, int> pastries = new Dictionary<string, int>()
            {
                {"Bread", 0},
                {"Cake", 0 },
                {"Pastry", 0},
                {"Fruit Pie", 0 }

            };

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                
                    int currentLiquid = liquids.Dequeue();
                    int currentIngredient = ingredients.Pop();

                    sum = currentIngredient + currentLiquid;
                

                if (sum == 25)
                {
                    pastries["Bread"]++;
                    
                }
                else if (sum == 50)
                {
                    pastries["Cake"]++;
                   
                }
                else if (sum == 75)
                {
                    pastries["Pastry"]++;
                    
                }
                else if (sum == 100)
                {
                    pastries["Fruit Pie"]++;
                    
                }
                else
                {
                    
                    currentIngredient += 3;
                    ingredients.Push(currentIngredient);
                }
            
            }

            
            if (pastries.All(x => x.Value > 0))
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine($"Liquids left: none");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine($"Ingredients left: none");
            }

            foreach (var item in pastries.OrderBy(x=>x.Key))
            {

                Console.WriteLine($"{item.Key}: {item.Value}");

            }
            

        }

    }
}
