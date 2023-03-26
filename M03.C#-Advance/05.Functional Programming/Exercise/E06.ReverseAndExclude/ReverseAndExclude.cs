using System;
using System.Collections.Generic;
using System.Linq;

class ReverseAndExclude
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .Reverse()
        .ToArray();

        int y = int.Parse(Console.ReadLine());

        Func<int, int, bool> isDev = (x, y) => (x % y == 0);

        List<int> result = numbers.Where(x => !isDev(x, y)).ToList();
        Console.WriteLine(String.Join(" ", result));
    }
}

