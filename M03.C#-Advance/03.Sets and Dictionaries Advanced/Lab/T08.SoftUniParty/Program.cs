using System;
using System.Collections.Generic;

namespace T08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<string> partyGuests = new HashSet<string>();

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "PARTY")
                {
                    break;
                }
                partyGuests.Add(commands);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (partyGuests.Contains(input))
                {
                    partyGuests.Remove(input);
                }
            }
            Console.WriteLine(partyGuests.Count);
            foreach (var item in partyGuests)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in partyGuests)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
