using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                int currOrder = queue.Peek();
                if (foodQuantity >= currOrder)
                {
                    foodQuantity -= currOrder;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
        }
    }
}
