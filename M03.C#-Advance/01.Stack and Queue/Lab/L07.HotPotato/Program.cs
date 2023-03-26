using System;
using System.Collections.Generic;

namespace L07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(input);

            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    
                    string name = queue.Dequeue();
                    queue.Enqueue(name);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
