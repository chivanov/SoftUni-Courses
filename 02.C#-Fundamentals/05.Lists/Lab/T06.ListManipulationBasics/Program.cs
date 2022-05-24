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

            while (command != "end")
            {
               //command = input[0];
               
                if (command == "Add")
                {
                   token = int.Parse(input[1]);
                    numbers.Add(token); 

                }
                else if (command == "Remove")
                {
                    token = int.Parse(input[1]);
                    numbers.Remove(token);   
                }
                else if (command == "RemoveAt")
                {
                    token = int.Parse(input[1]);
                    numbers.RemoveAt(token);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse (input[2]);
                    token = int.Parse(input[1]);
                    numbers.Insert(index, token);    
                }

                input = Console.ReadLine().Split(' ').ToArray();
                command = input[0];
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
