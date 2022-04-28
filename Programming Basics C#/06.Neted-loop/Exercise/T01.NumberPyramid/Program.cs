using System;

namespace T01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());
            int row = 1;
            int currNum = 1;
            bool isEqual = false;

            while (!isEqual)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write($"{currNum} ");
                    currNum++;
                    if (currNum > targetNumber)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}
