using System;
using System.Linq;

namespace E01.ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = null;

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Create")
                {
                    list = new ListyIterator<string>(tokens.Skip(1).ToArray());
                }
                else if (tokens[0] == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (tokens[0] == "Print")
                {
                    list.Print();
                }
                else if (tokens[0] == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
            }
        }
    }
}
