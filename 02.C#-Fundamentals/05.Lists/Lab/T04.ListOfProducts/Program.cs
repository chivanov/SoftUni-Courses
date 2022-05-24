using System;
using System.Collections.Generic;

namespace T04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();
            int counter = 0;

            for (int i = 0; i < numberOfProducts; i++)
            {
                string product = Console.ReadLine();
                listOfProducts.Add(product);
                counter = i;
            }
                listOfProducts.Sort();

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i+1}.{listOfProducts[i]}");
            }

           
        }
    }
}
