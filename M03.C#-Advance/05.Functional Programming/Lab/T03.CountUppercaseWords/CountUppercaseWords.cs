using System;
using System.Linq;

internal class CountUppercaseWords
{

    static void Main()
    {
        Predicate<string> isCapitalFirstLetter = (string x) => x.Length > 0 && char.IsUpper(x[0]);

        Console.WriteLine(String.Join("\r\n", Console.ReadLine()
            .Split(" ")
            .Where(x => isCapitalFirstLetter(x))
            .ToArray()));
    }
}

