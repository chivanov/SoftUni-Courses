using System;

internal class ActionPoint
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        Action<string[]> printNames = allNames => Console.WriteLine(string.Join(Environment.NewLine, names));
        printNames(names);
    }
}

