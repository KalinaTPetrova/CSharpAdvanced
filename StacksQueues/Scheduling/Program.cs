using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int taskToKill = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(", ",tasks));
            //Console.WriteLine(string.Join(" ", threads));
            //Console.WriteLine(taskToKill);


            while (tasks.Count > 0 || threads.Count > 0)


            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if (currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", threads));

                    break;
                }

                if (currentThread >= currentTask)
                {
                   
                    tasks.Pop();
                    threads.Dequeue();



                }
                else if (currentThread < currentTask)
                {
                    

                    threads.Dequeue();
                }
            }
        }
    }
}
