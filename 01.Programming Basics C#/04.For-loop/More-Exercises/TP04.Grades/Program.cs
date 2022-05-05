using System;

namespace TP04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            

            int topStudent = 0;
            int veryGoodStudents = 0;
            int goodStudents = 0;
            int failStudents = 0;
            double totalScore = 0;

            for (int i = 1; i <= numberOfStudents; i++)
            {
                double studentScore = double.Parse(Console.ReadLine());
                totalScore += studentScore;
                if (studentScore >= 2.00 && studentScore <= 2.99)
                {
                    failStudents ++;
                }
                else if (studentScore >= 3.00 && studentScore <= 3.99)
                {
                    goodStudents ++;
                }
                else if (studentScore >= 4.00 && studentScore <= 4.99)
                {
                    veryGoodStudents ++;
                }
                else if (studentScore >= 5.00 && studentScore <= 6.00)
                {
                    topStudent++;
                }
            }

            double percentTopStudents = 1.0 * topStudent / numberOfStudents * 100;
            double percentVeryGoodStudents = 1.0 * veryGoodStudents / numberOfStudents * 100;
            double percentGoodStudents = 1.0 * goodStudents / numberOfStudents * 100;
            double percentFailStudents = 1.0 * failStudents / numberOfStudents * 100;
            double averageScore = totalScore / numberOfStudents;
          
            Console.WriteLine($"Top students: {percentTopStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentVeryGoodStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentGoodStudents:f2}%");
            Console.WriteLine($"Fail: {percentFailStudents:f2}%");
            Console.WriteLine($"Average: {averageScore:f2}");
        }
    }
}
