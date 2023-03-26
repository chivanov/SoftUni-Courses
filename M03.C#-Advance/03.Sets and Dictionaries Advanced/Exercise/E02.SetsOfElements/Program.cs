using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> set1 = new HashSet<int>(); 
            HashSet<int> set2 = new HashSet<int>();
            int n = numbers[0];
            int m = numbers[1];

            for (int i = 1; i <= n+m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    set1.Add(num);
                }
                else
                {
                    set2.Add(num);
                }
            }

            foreach (var item1 in set1)
            {
                foreach (var item2 in set2)
                {
                    int num1 = item1;
                    if (num1 == item2)
                    {
                        Console.Write($"{item2} ");
                    }
                }
            }
        }
    }
}
