using System;
using System.Linq;

 class SumNumbers
{
    static int Parse(string str) => int.Parse(str);
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(Parse).ToArray();

        Console.WriteLine(numbers.Count());
        Console.WriteLine(numbers.Sum());
    }
}

