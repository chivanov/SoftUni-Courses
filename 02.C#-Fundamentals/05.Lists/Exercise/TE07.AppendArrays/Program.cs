using System;
using System.Collections.Generic;
using System.Linq;

namespace TE06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)               
                .ToList();

            List<string> newList = new List<string>();


            for (int i = lists.Count-1; i >= 0; i--)
            {
                var currentList = lists[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in currentList)
                {
                    newList.Add(item);
                }
            }

            Console.WriteLine(String.Join(' ', newList));
        }
    }
}
