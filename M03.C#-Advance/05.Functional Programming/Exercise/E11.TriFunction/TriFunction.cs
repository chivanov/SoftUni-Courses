using System;
using System.Linq;

class TriFunction
{
    static void Main()
    {
        
        int requiredSum = int.Parse(Console.ReadLine());

        string[] names = Console.ReadLine().Split();

        Func<string, int, bool> isBiggerOrEguql = (name, sum) => name.Sum(x => x) >= sum;

        Func<string[], int, Func<string, int, bool>, string> getName = (names, ascii, func) => names.Where(x => func(x, ascii)).FirstOrDefault();
        var name = getName(names, requiredSum, isBiggerOrEguql);

        Console.WriteLine(name);

    }
} 

