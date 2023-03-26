using System;
using System.Linq;

namespace PE01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] username = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in username)
            {
                if (word.Length > 3 && word.Length <= 16)
                {
                    bool isValid = true;

                    foreach (char currChar in word)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '_' || currChar == '-'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
