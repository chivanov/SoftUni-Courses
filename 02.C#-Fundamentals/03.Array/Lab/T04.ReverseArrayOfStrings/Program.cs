using System;
using System.Linq;

namespace T04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries) 
                 .ToArray();
            for (int i = 0; i < arr.Length/2; i++)
            {
                string oldElement = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
