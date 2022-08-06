using System;
using System.Collections.Generic;
using System.Linq;

class AddVAT
{
    static void Main()
    {
        Func<decimal, decimal> addVAT = x => x * 1.20m;

        string input = Console.ReadLine();
        decimal[] nums = input.Split(", ").Select(decimal.Parse).ToArray();
        decimal[] sumWithVAT = nums.Select(addVAT).ToArray();

        Array.ForEach(sumWithVAT, x => Console.WriteLine("{0:f2}", x));
    }
}

