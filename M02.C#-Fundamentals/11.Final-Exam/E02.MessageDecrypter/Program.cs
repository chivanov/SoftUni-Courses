using System;
using System.Text;
using System.Text.RegularExpressions;

namespace E02.MessageDecrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^([$|%])(?<tag>[A-Z][a-z]{2,})\1: \[(?<num1>[0-9]+)\]\|\[(?<num2>[0-9]+)\]\|\[(?<num3>[0-9]+)\]\|$";

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match match = Regex.Match(text, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    char characterOne = (char)(int.Parse(match.Groups["num1"].ToString()));
                    char characterTwo = (char)(int.Parse(match.Groups["num2"].ToString()));
                    char characterThree = (char)(int.Parse(match.Groups["num3"].ToString()));

                    char[] chars = { characterOne, characterTwo, characterThree };

                    string tag = match.Groups["tag"].ToString();
                    string result = new string(chars);

                    Console.WriteLine($"{tag}: {result}");
                }

            }
        }
    }
}
