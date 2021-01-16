using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {

                string command = Console.ReadLine();

                if (command == "Play")
                {

                    songs.Dequeue();
                }

                else if (command.StartsWith("Add"))
                {

                    string song = command.Substring(4);
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }

                else if (command == "Show")
                {

                    Console.WriteLine(string.Join(", ", songs));
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}

