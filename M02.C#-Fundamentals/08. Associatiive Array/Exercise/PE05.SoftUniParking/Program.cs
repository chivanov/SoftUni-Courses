using System;
using System.Collections.Generic;

namespace PE05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberIterations = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();  

            for (int i = 0; i < numberIterations; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); 

                string command = input[0];
                string userName = input[1];
               

                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    if (registeredUsers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        registeredUsers.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!registeredUsers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        registeredUsers.Remove(userName);   
                    }
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
