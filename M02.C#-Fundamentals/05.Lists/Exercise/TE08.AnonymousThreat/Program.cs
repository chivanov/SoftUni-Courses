using System;
using System.Collections.Generic;
using System.Linq;

namespace TE08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> imput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = imput[0];

            while (command!= "3:1")
            {

                imput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
        }
    }
}
