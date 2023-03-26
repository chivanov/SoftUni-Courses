using System;
using System.Linq;

internal class SortEvenNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .ToArray();

        Console.WriteLine(String.Join(", ", numbers));
    }
}

