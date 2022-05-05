using System;

namespace TP05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menNumber = int.Parse(Console.ReadLine());
            int womenNumber = int.Parse(Console.ReadLine());
            int maxTabels = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int man = 1; man <= menNumber; man++)
            {
                for (int woman = 1; woman <= womenNumber; woman++)
                {
                    combinations++;
                    if (combinations <= maxTabels)
                    {
                        Console.Write($"({man} <-> {woman}) ");
                    }
                }
            }

        }
    }
}
