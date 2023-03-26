using System;
using System.Linq;

namespace PL04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length % 2 == 0).ToArray();

            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
        }      
       
	

	}
    
}
