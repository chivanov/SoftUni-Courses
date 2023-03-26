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
            List<int> list = new List<int>();
            for (int i = 0; i < lines; i++)
            {
                int  input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<int>(list);
           
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int indexOne = indexes[0];
            int indexTwo = indexes[1];

            box.Swap(list, indexOne, indexTwo);

            Console.WriteLine(box);
        }
    }
}
