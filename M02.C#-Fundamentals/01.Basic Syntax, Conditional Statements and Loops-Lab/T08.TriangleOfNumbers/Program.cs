﻿using System;

namespace T08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {

                    Console.Write($"{i} ");
                }
            }
        }
    }
}
