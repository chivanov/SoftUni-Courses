using System;

namespace T04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int evaluatosNumber = int.Parse(Console.ReadLine());
            string input = Console.ReadLine ();
            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= evaluatosNumber; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    gradeCount++;
                    sumOfAllGrades += grade;
                }

                double averegeForCurrentPresentationn = sumOfGrades / evaluatosNumber;
                Console.WriteLine($"{input} - {averegeForCurrentPresentationn:f2}.");

                input = Console.ReadLine();
            }
            double averegeFinalGrade = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {averegeFinalGrade:f2}.");
             
        }
    }
}
