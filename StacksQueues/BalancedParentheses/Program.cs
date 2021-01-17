using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool match = true;
            foreach (char item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    parentheses.Push(item);
                }

                else if (item == ')' || item == '}' || item == ']')
                {
                    if (parentheses.Count <= 0)
                    {

                        match = false;
                        break;
                    }
                    if (item == ')'&& parentheses.Pop() == '(')
                    {
                        continue;
                    }
                    if (item == '}' && parentheses.Pop() == '{')
                    {
                        continue;
                    }
                    if (item == ']' && parentheses.Pop() == '[')
                    {
                        continue;
                    }
                    else
                    {
                        match = false; break;
                    }
                }

                


            }
                if (parentheses.Count > 0) { match = false; }
            if (match)
            {
                Console.WriteLine("YES");
            }
            else { Console.WriteLine("NO"); }
        }
    }
}