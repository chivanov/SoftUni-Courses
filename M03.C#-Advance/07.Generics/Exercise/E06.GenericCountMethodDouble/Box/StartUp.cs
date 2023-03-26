using System;
using System.Collections.Generic;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();

            for (int i = 0; i < lines; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            double textToCompare = double.Parse(Console.ReadLine());

            var box = new Box<double>(list);

            int count = box.CountOfGreaterLement(list, textToCompare);
            Console.WriteLine(count);   


        }
    }
}
