using System;

namespace E01.StringGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] cmdInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdInfo[0];

                if (command == "Change")
                {
                    string ch = cmdInfo[1]; 
                    string replacement = cmdInfo[2];

                    message = ReplaceChar(message, ch, replacement);                   
                    
                }
                else if (command == "Includes")
                {
                    string substring = cmdInfo[1];

                    IsIncludeSubstring(message, substring);
                }
                else if (command == "End")
                { 
                string substring = cmdInfo[1];
                    CheckEndSubstring(message, substring);
                }
                else if (command == "Uppercase")
                {
                    message= message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (command == "FindIndex")
                {
                    string ch = cmdInfo[1]; 
                    int index = message.IndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(cmdInfo[1]);
                    int count = int.Parse(cmdInfo[2]);
                    message = CutString(message, startIndex, count);
                    Console.WriteLine(message);
                }
              
            }
        }

        private static string ReplaceChar(string message, string ch, string replacement)
        {
            if (message.Contains(ch))
            {
                message = message.Replace(ch, replacement);
                Console.WriteLine(message);
            }
            return message;


        }

        private static void IsIncludeSubstring(string message, string substring)
        {
           bool isValid = message.Contains(substring);
            Console.WriteLine(isValid);
        }

        private static void CheckEndSubstring(string message, string substring)
        {
            
            if (message.EndsWith(substring))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

          
        }

        private static string CutString(string message, int startIndex, int count)
        {
            return message.Substring(startIndex, count);
        }
    }
}
