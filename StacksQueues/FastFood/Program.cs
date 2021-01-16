using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(input);
            Console.WriteLine(orders.Max());
            bool enoughFood = true;
            while(orders.Count>0)
            {
                int currOrder = orders.Peek();
                if (food >= currOrder)
                {
                    orders.Dequeue();
                    food -= currOrder;
                }
                else
                {
                    enoughFood = false;
                    break;
                }
            }
            if (!enoughFood)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
