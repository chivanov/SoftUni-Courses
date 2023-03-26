using System;
using System.Collections.Generic;

namespace L06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();  
            string input;
            
            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
