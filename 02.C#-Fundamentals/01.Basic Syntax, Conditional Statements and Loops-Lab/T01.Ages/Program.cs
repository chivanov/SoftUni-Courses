﻿using System;

namespace T01.Ages
{
    internal class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine()!);
          

            if (age >=0 && age <=2)
            {
                Console.WriteLine("baby");
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }

        }
    }
}
