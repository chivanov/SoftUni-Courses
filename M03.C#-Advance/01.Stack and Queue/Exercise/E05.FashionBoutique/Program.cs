using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);
            int sum = 0;
            int racks = 1;

            while (stack.Count > 0)
            {
                int currCloth = stack.Pop();
                if (sum + currCloth <= rackCapacity)
                {
                    sum += currCloth;
                }
                else
                {
                    sum = currCloth;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}

