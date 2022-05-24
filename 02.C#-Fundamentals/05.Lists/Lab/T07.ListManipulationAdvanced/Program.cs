using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine().Split(' ').ToArray();

            string command = input[0];
            int token = 0;
            bool hasChanges = false;

            while (command != "end")
            {

                if (command == "Add")
                {
                    token = int.Parse(input[1]);
                    numbers.Add(token);
                    hasChanges = true;

                }
                else if (command == "Remove")
                {
                    token = int.Parse(input[1]);
                    numbers.Remove(token);
                    hasChanges = true;
                }
                else if (command == "RemoveAt")
                {
                    token = int.Parse(input[1]);
                    numbers.RemoveAt(token);
                    hasChanges = true;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input[2]);
                    token = int.Parse(input[1]);
                    numbers.Insert(index, token);
                    hasChanges = true;
                }
                else if (command == "Contains")
                {
                    token = int.Parse(input[1]);                    
                    hasChanges = true;
                    if (numbers.Contains(token))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven ")
                {
                    numbers.RemoveAll(x => x % 2 != 0);
                    Console.WriteLine(String.Join (' ', numbers));
                }
                else if (command == "PrintOdd")
                {
                    numbers.RemoveAll(x => x % 2 == 0);
                    Console.WriteLine(String.Join(' ', numbers));
                }
                else if (command == "GetSum")
                {
                   
                    Console.WriteLine(String.Join(' ', numbers.Sum()));
                }
                else if (command == "Filter")
                {
                    int index = int.Parse(input[2]);
                    string condition = input[1];
                    List<int> result = filter(numbers, condition, index);

                    Console.WriteLine(string.Join(' ', result));
                }

                input = Console.ReadLine().Split(' ').ToArray();
                command = input[0];
            }
            if (hasChanges)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }

        static List<int> filter (List<int> numbers, string condition, int numberToCompare)
        {
            if (condition == "<")
            {
                List<int> result = numbers.FindAll(x => x < numberToCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = numbers.FindAll(x => x > numberToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = numbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = numbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            else
            {
                return numbers;
            }
        }
    }
}
