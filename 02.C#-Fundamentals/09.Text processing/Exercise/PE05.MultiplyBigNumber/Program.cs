using System;
using System.Text;

namespace PE05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int restNum = 0;
            if (number == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currNum = int.Parse(number[i].ToString());
                int product = currNum * multiplier + restNum;
                int result = product % 10;
                restNum = product / 10;

                sb.Insert(0, result);               
            }
            if (restNum > 0)
            {
                sb.Insert(0, restNum);
            }
            Console.WriteLine(sb);

        }
    }
}