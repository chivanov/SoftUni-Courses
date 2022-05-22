using System;
using System.Collections.Generic;
using System.Linq;

namespace TE03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> partyMembers = new List<string>();
            

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                string person = input[0];
                string command = input[2];

                if (partyMembers.Contains(person) && command == "going!")
                {
                    Console.WriteLine($"{person} is already in the list!"); 
                }
                else if (partyMembers.Contains(person) && command == "not")
                {
                    partyMembers.Remove(person);
                }
                else if (!partyMembers.Contains(person) && command == "not")
                {
                    Console.WriteLine($"{person} is not in the list!");
                }
                else
                {
                    partyMembers.Add(person);
                }              

            }

            foreach (string person in partyMembers)
            {
                Console.WriteLine(person);
            }
        }
    }
}
