using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int n = nums[0];
            int m = nums[1];

            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();


            for (int i = 0; i < n; i++)
            {
                int inputN = int.Parse(Console.ReadLine());
                nSet.Add(inputN);
            }

            for (int i = 0; i < m; i++)
            {
                int inputM = int.Parse(Console.ReadLine());
                mSet.Add(inputM);

            }

            foreach (var item in nSet)
            {

                if (mSet.Contains(item))
                {
                    Console.Write(item+" ");
                }
            }

        }
    }
}
