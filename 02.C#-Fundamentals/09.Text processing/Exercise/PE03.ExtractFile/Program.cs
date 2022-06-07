using System;
using System.Linq;

namespace PE03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

           GetNameAndExtention(text.Last());

        }

        static void GetNameAndExtention(string input)
        {           

            int dotIndex = input.LastIndexOf('.');

            string name = input.Substring(0, dotIndex);
            string extention = input.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
