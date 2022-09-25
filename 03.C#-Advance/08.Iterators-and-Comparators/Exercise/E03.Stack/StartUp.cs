using System;
using System.Linq;

namespace E03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            string input;
            while ((input=Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Push")
                {
                    stack.Push(tokens.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (tokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (AggregateException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
