using System;
using System.Linq;

class CustomMinFunction
{
    static void Main()
    {
        int[] numbersFromConsole = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int[], int> getMinNumber = number =>
        {
            int minNum = int.MaxValue;

            foreach (var num in number)
            {
                if (num < minNum)
                {
                    minNum = num;
                }
            }
            return minNum;
        };
        // Func<int[], int> getMinNumber = num => num.Min();

        int result = getMinNumber(numbersFromConsole);

        Console.WriteLine(result);

    }
}

