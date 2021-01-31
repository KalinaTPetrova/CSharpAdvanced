using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            
            string command = Console.ReadLine();


            Func<List<int>, string, List<int>> result = (nums, cmd) =>
               {
                   List<int> newNums = new List<int>();

                   if (cmd == "add")
                   {
                       newNums = nums.Select(n => n + 1).ToList();
                   }
                   else if (cmd == "multiply")
                   {
                       newNums = nums.Select(n => n * 2).ToList();

                   }
                   else if (cmd == "subtract")
                   {
                       newNums = nums.Select(n => n - 1).ToList();

                   }
                   return newNums;
               };

            

            while (command != "end")
            {

                


                    if (command == "print")
                { 
                    Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
                    print(numbers);
                }
                else
                {
                    numbers = result(numbers, command);
                }
                    

               

                command = Console.ReadLine();
            }
        }
    }
}
