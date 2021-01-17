using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                bool success = true;
                int currPetrol = 0;
                
                for (int j = 0; j < n; j++)
                {

                    string currStation = pumps.Dequeue();
                    pumps.Enqueue(currStation);
                    if (success)
                    {

                    string[] input = currStation.Split();
                    currPetrol += int.Parse(input[0]) - int.Parse(input[1]);
                    if (currPetrol < 0)
                    {
                        success = false;
                      
                    }                    
                    }
               
                }
                if (success)
                {
                    Console.WriteLine(i);
                    break;
                }

                string tempPumps = pumps.Dequeue();
                pumps.Enqueue(tempPumps);

            }
        }
    }
}
