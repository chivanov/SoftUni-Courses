using System;

namespace TP05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMoves = int.Parse(Console.ReadLine());

            double result = 0;
            int from0To9 = 0;
            int from10To19 = 0;
            int from20To29 = 0;
            int from30T039 = 0;
            int from40T050 = 0;
            int invalid = 0;
            for (int i = 0; i < numberOfMoves; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    from0To9++;
                    result += num * 0.2;
                }
                else if (num >= 10 && num <= 19)
                {
                    from10To19++;
                    result += num * 0.3;
                }
                else if (num >= 20 && num <= 29)
                {
                    from20To29++;
                    result += num * 0.4;
                }
                else if (num >= 30 && num <= 39)
                {
                    from30T039++;
                    result += 50;
                }
                else if (num >= 40 && num <= 50)
                {
                    from40T050++;
                    result += 100;
                }
                else 
                {
                    invalid++;
                    result /= 2;
                }
            }

            double percentFromoTo9 = (double)from0To9 / numberOfMoves * 100;
            double percentFrom10To19 = (double)from10To19 / numberOfMoves * 100;
            double percentFrom20T029 = (double)from20To29 / numberOfMoves * 100;
            double percentFrom30T039 = (double)from30T039 / numberOfMoves * 100;
            double percentFRom40To50 = (double)from40T050 / numberOfMoves * 100;
            double percentInvalite = (double)invalid / numberOfMoves * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {percentFromoTo9:f2}%");
            Console.WriteLine($"From 10 to 19: {percentFrom10To19:f2}%");
            Console.WriteLine($"From 20 to 29: {percentFrom20T029:f2}%");
            Console.WriteLine($"From 30 to 39: {percentFrom30T039:f2}%");
            Console.WriteLine($"From 40 to 50: {percentFRom40To50:f2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalite:f2}%");

        }
    }
}
