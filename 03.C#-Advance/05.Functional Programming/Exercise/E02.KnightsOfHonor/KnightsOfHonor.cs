using System;

internal class KnightsOfHonor
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        Action<string[], string> printNames = (allNames, title) => Console.WriteLine(title + string.Join(Environment.NewLine + title, names));
        printNames(names, "Sir ");
    }
}




