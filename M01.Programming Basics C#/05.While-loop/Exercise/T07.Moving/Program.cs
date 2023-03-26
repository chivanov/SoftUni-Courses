using System;

namespace T07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthArea = int.Parse(Console.ReadLine());
            int lengthArea = int.Parse(Console.ReadLine());
            int heightArea = int.Parse(Console.ReadLine());

            int totalFreeArea = widthArea * lengthArea * heightArea;

            while (totalFreeArea > 0)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    break;
                }
                int usedSpace = int.Parse(command);
                totalFreeArea -= usedSpace;
            }
            if (totalFreeArea >= 0)
            {
                Console.WriteLine($"{Math.Abs(totalFreeArea)} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeArea)} Cubic meters more.");
              
            }
        }
    }
}
