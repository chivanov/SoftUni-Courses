using System;
using System.Collections.Generic;

namespace PE02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> resourses = new Dictionary<string, int>();  
            while (command != "stop")
            {
                int quantity = int.Parse (Console.ReadLine());
                if (resourses.ContainsKey(command))
                {
                    resourses[command] += quantity;
                }
                else 
                { 
                resourses.Add(command, quantity);   
                }
                
                command = Console.ReadLine();
            }

            foreach (var pair in resourses)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
