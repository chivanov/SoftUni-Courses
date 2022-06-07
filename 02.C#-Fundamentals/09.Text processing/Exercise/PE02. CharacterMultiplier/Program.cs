using System;

namespace PE02._CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] text = Console.ReadLine().Split(' ');

            Console.WriteLine(GetStringsSum (text[0], text[1])); 
        }

        static int GetStringsSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < minLength; i++) 
            {
                sum += stringOne[i] * stringTwo[i];            
            }

            string maxLength = stringOne;

            if (maxLength.Length < stringTwo.Length)
            {
                maxLength = stringTwo;
            }

            for (int i = minLength; i < maxLength.Length; i++)
            {
                sum += maxLength[i];
            }


            return sum;
        }
    }
}
