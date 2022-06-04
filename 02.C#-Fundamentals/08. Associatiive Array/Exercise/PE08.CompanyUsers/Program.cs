using System;
using System.Collections.Generic;
using System.Linq;

namespace PE08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();


            while (command != "End")
            {
                string[] input = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = input[0];
                string employeeID = input[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                    companies[companyName].Add(employeeID);
                }
                else
                {
                    if (!companies[companyName].Contains(employeeID))
                    {
                        companies[companyName].Add(employeeID);
                    }
                }


                command = Console.ReadLine();
            }

            foreach (var item in companies)
            {
                string name = item.Key;
                List<string> IDs = item.Value;

                Console.WriteLine($"{name}");
                foreach (var ID in IDs)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
