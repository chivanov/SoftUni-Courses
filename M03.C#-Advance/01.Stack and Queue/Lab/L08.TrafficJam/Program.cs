using System;
using System.Collections.Generic;

namespace L08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsNumber = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int count = 0;

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
               
                if (input == "green")
                {
                    for (int i = 0; i < carsNumber; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                        else
                        {
                            break; 
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
