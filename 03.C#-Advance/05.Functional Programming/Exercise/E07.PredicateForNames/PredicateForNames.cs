using System;
using System.Collections.Generic;

internal class PredicateForNames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] names = Console.ReadLine().Split();

        Func<string, int, bool> isInRange = (x,y) => (x.Length <= y);
        List<string> result = new List<string>();   
        foreach (var name in names)
        {
            if (isInRange(name, n))
            {
                Console.WriteLine(name);
            }
        };
    }

   
}

