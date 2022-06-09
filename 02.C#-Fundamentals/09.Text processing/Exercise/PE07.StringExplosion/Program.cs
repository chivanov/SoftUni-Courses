using System;
using System.Text;

namespace PE07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '>')
                {
                    if (power == 0)
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        power--;
                    }                    
                }
                else
                {
                    if (text[i] == '>')
                    {
                        sb.Append(text[i]);
                    }

                    char nextChar = text[i + 1];
                    string powerString = nextChar.ToString();
                    power = int.Parse(powerString)+power;
                    power--;                   
                    i++;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
