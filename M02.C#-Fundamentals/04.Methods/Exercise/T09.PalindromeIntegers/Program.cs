using System;

namespace T09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); ;

            do
            {
                if (ValidateNumberIsPalindrome(input) == input)
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            } while (input != "END");
            
            //while (input != "End")
            //{               
            //    input = Console.ReadLine();

            //    if (ValidateNumberIsPalindrome(input) == input)
            //    {
            //        Console.WriteLine("true");
            //    }

            //    else
            //    {
            //        Console.WriteLine("false");
            //    }
            //}          

        }

        static string ValidateNumberIsPalindrome(string input)
        {
            string reversString = String.Empty;            

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char symbol = input[i];
                reversString += symbol;
            }

            return reversString; 
        }
    }
}
