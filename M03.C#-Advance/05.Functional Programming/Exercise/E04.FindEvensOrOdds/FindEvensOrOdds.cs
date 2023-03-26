using System;
using System.Collections.Generic;
using System.Linq;

class FindEvensOrOdds
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int startNum = input[0];
        int range = input[1];

        List<int> numbers = new List<int>();

        for (int i = startNum; i <= range; i++)
        {
            numbers.Add(i);
        }

        string oddOrEven = Console.ReadLine();
        Predicate<int> isEven = x => x % 2 == 0;    
        Predicate<int> isOdd = x => x % 2 != 0;    

        if (oddOrEven == "even")
        {
            List<int> result = numbers.FindAll(isEven);
            Console.WriteLine(string.Join(' ', result));
        }
        else
        {
            List<int> result = numbers.FindAll(isOdd);
            Console.WriteLine(string.Join(' ', result));
        }

    }
}

