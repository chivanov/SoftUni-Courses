using System;
using System.Collections.Generic;
using System.Linq;

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

            var box = new Box<string>(list);
           
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int indexOne = indexes[0];
            int indexTwo = indexes[1];

            box.Swap(list, indexOne, indexTwo);

            Console.WriteLine(box);
        }
    }
}
