using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            Stack<string> text = new Stack<string>();
            text.Push(builder.ToString());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "1":
                        builder.Append(cmdArgs[1]);
                        text.Push(builder.ToString());
                        break;
                    case "2":
                        int num = int.Parse(cmdArgs[1]);
                        builder.Remove(builder.Length - num, num);
                        text.Push(builder.ToString());
                        break;
                    case "3":
                        int index = int.Parse(cmdArgs[1]);
                       
                                Console.WriteLine(builder[index-1]);
                        
                        break;
                    case "4":
                        text.Pop();
                        builder = new StringBuilder();
                        builder.Append(text.Peek());
                        break;
                }

            }
        }
    }
}
