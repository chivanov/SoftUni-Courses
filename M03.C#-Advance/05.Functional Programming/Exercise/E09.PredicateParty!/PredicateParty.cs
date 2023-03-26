using System;
using System.Collections.Generic;
using System.Linq;

class PredicateParty
{
    static void Main()
    {
        List<string> guestNames = Console.ReadLine().Split().ToList();

        string command = Console.ReadLine();

        while (command != "Party!")
        {
            string[] tokens = command.Split();
            string method = tokens[0];  
            string action = tokens[1];  
            string value = tokens[2];
            if (method == "Double")
            {
                List<string> doubleNames = guestNames.FindAll(GetPredicate(action, value));
                if (!doubleNames.Any())
                {
                    command = Console.ReadLine();
                    continue;
                }
                int index = guestNames.FindIndex(GetPredicate(action, value));

                guestNames.InsertRange(index, doubleNames);
            }
            else
            {
                guestNames.RemoveAll(GetPredicate(action, value)); 
            }

            command = Console.ReadLine();
        }

        if (guestNames.Any())
        {
            Console.WriteLine($"{string.Join(", ", guestNames)} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }

    private static Predicate<string> GetPredicate(string action, string value)
    {
        if (action == "StartsWith")
        {
            return x => x.StartsWith(value);
        }

        if (action == "EndsWith")
        {
            return x => x.EndsWith(value);
        }

        return x => x.Length == int.Parse(value);
    }
}

