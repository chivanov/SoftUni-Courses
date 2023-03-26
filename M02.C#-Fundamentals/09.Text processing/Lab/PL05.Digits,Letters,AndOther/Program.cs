using System;
using System.Text;

namespace PL05.Digits_Letters_AndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder otherChar = new StringBuilder();

            string text = Console.ReadLine();

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
                else if (char.IsDigit(character))
                {

                    digits.Append(character);
                }
                else if (!char.IsLetterOrDigit(character))
                {
                    otherChar.Append(character);
                }
            }
            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());  
            Console.WriteLine(otherChar.ToString());    
        }
    }
}
