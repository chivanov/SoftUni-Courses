using System;
using System.Collections.Generic;
using System.Linq;

namespace PE04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student();    
                student.FirstName = input[0];   
                student.LastName = input[1];    
                student.Grade = double.Parse(input[2]);

                students.Add(student);  
            }

            students = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
