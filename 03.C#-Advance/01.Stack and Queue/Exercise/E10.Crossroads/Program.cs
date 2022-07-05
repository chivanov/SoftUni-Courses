using System;
using System.Collections.Generic;

namespace E10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int count = 0;
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int totalDuration = greenLightDuration + freeWindowDuration;
                    Queue<char> queue2 = new Queue<char>(queue.Dequeue());

                    for (int i = 0; i < totalDuration; i++)
                    {
                        count = i;
                        while (queue2.Count > 0)
                        {
                            queue2.Dequeue();
                        }
                        //if (queue.Count > 0)
                        //{
                        //    queue2.Enqueue(new Queue<char>(queue.Dequeue());
                        //}
                        //else
                        //{
                        //    break;
                        //}

                    }
                    if (queue.Count > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"Hummer was hit at {queue2.Dequeue()}.");
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
