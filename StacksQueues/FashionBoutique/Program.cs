using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> box = new Stack<int>(clothes);

            int racks = 1;
            int sum = 0;
            while (box.Count > 0)
            {
                if (capacity >= sum+box.Peek())
                {
                    sum += box.Pop();
                    
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
