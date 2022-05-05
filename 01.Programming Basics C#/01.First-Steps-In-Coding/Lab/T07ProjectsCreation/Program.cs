using System;

namespace T07ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectNumber = int.Parse(Console.ReadLine());
            const double timePerProject = 3;

            double totalTime = projectNumber * timePerProject;
            Console.WriteLine($"The architect {name} will need {totalTime} hours to complete {projectNumber} project/s.");


        }
    }
}
