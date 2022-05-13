using System;
using System.Linq;

namespace T01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVagons = int.Parse(Console.ReadLine());

            int[] people = new int[numberOfVagons];

            int sum = 0;

            for (int i = 0; i < numberOfVagons; i++)
            {

                people[i] = int.Parse(Console.ReadLine());

                sum += people[i];
            }
            Console.Write(String.Join(' ', people));
            Console.WriteLine();

            Console.WriteLine(sum);

        }
    }
}
