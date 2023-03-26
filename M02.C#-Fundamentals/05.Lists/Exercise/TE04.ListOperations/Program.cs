using System;
using System.Collections.Generic;
using System.Linq;

namespace TE04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "End")
            {

                if (command[0] == "Add" && (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= numbers.Count))
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert" && (int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= numbers.Count))
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Remove" && (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= numbers.Count))
                {
                    numbers.Remove(numbers[int.Parse(command[1])]);
                }
                else if (command[1] == "left")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        int currNum = numbers[0];
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = currNum;

                    }
                }
                else if (command[1] == "right")
                {
                    for (int i = int.Parse(command[2]); i > 0; i--)
                    {
                        int currNum = numbers[numbers.Count - 1];

                        for (int j = numbers.Count - 1; j > 0; j--)
                        {
                            numbers[j] = numbers[j - 1];
                        }

                        numbers[0] = currNum;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
