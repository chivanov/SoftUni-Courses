using System;
using System.Linq;

class AppliedArithmetics
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string command = Console.ReadLine();
        Action<int[]> add = elements =>
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] += 1;
            }
        
        };
        Action<int[]> multiply = elements =>
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] *= 2;
            }

        };
        Action<int[]> subtract = elements =>
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] -= 1;
            }

        };
        Action<int[]> print = elements =>
        {
            Console.WriteLine(String.Join(" ", elements));

        };
        while (command != "end")
        {
            if (command == "add")
            {
                add(numbers);
            }
            else if (command == "multiply")
            {
                multiply(numbers);
            }
            else if (command == "subtract")
            {
                subtract(numbers);
            }
            else if (command == "print")
            {
                print(numbers);
            }         
            
            command = Console.ReadLine();
        }

      
    }
}

