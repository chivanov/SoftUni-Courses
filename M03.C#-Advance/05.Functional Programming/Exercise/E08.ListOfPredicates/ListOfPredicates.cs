using System;
using System.Collections.Generic;
using System.Linq;

class ListOfPredicates
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = Enumerable.Range(1, n).ToList();

        int[] devNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        List<Predicate<int>> predicates = new List<Predicate<int>>();

        foreach (var num in devNumbers)
        {
            predicates.Add(x => x % num == 0);
        }

        foreach (var number in numbers)
        {
            bool isDev = true;
            foreach (var predicate in predicates)
            {
                if (!predicate(number))
                {
                    isDev = false;
                    break;
                }
               
            }
            if (isDev)
            {
                Console.Write(number + " ");
            }
        }
    }
}

