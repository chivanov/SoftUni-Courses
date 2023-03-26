using System;
using System.Collections.Generic;
using System.Linq;

class ThePartyReservationFilterModule
{
    static void Main()
    {
        List<string> names = Console.ReadLine().Split().ToList();

        string command = Console.ReadLine();

        Dictionary<string, Predicate<string>> allFilters = new Dictionary<string, Predicate<string>>();

        while (command != "Print")
        {
            //Add filter; Starts with; P
            string[] tokens = command.Split(';');
            string method = tokens[0];
            string action = tokens[1];
            string value = tokens[2];

            if (method == "Add filter") 
            {
                allFilters.Add(action + value, GetPredicate(action, value));
            }
            else
            {
                allFilters.Remove(action + value);
            }

            command = Console.ReadLine();
        }
        foreach (var (key, value) in allFilters)
        {
            names.RemoveAll(value);
        }

        Console.WriteLine(String.Join(" ", names));
    }

    private static Predicate<string> GetPredicate(string action, string value)
    {
        if (action == "Starts with")
        {
            return x => x.StartsWith(value);
        }

        if (action == "Ends with")
        {
            return x => x.EndsWith(value);
        }

        if (action == "Contains")
        {
            return x => x.Contains(value);
        }

        return x => x.Length == int.Parse(value);
    }
}

