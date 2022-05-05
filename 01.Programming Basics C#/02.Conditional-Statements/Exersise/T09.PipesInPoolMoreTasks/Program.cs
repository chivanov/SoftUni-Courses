using System;

namespace T09.PipesInPoolMoreTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int poolVolume = int.Parse(Console.ReadLine());
            int pipe1Flow = int.Parse(Console.ReadLine());
            int pipe2Flow = int.Parse(Console.ReadLine());
            double leaveTime = double.Parse(Console.ReadLine());

            double littersPipe1 = pipe1Flow * leaveTime;
            double littersPipe2 = pipe2Flow * leaveTime;
            double totalLitters = littersPipe1 + littersPipe2;

            double percentTotalPollFill = totalLitters * 100 / poolVolume;
            double pipe1Percent = littersPipe1 * 100 / totalLitters;
            double pipe2Percent = littersPipe2 * 100 / totalLitters;

            double difference = Math.Abs(poolVolume - totalLitters);

            if (poolVolume > totalLitters)
            {
                Console.WriteLine($"The pool is {percentTotalPollFill:F2}% full. Pipe 1: {pipe1Percent:F2}%. Pipe 2: {pipe2Percent:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {leaveTime} hours the pool overflows with {difference:F2} liters.");
            }

        }
    }
}
