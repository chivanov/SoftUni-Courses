using System;
using System.Collections.Generic;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            string textToCompare = Console.ReadLine();

            var box = new Box<string>(list);

            int count = box.CountOfGreaterLement(list, textToCompare);
            Console.WriteLine(count);   


        }
    }
}
