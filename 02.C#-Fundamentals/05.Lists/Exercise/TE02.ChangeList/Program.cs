using System;
using System.Collections.Generic;
using System.Linq;

namespace TE02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> input = command.Split(' ').ToList();
                string toDo = input[0];
                int element = 0;
                int possition = 0;

                switch (toDo)
                {
                    case "Delete":
                        element = int.Parse(input[1]);
                        numbers.RemoveAll(x => x == element);

                        break;
                    case "Insert":
                        element = int.Parse(input[1]);
                        possition = int.Parse(input[2]);
                        numbers.Insert(possition, element);  
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
