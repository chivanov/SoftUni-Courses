using System;
using System.Collections.Generic;

namespace PL04.Students
{

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            

            //string command = input[0];

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries); 

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown,
                };

                students.Add(newStudent);

                //input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                command = Console.ReadLine();   
            }

            string town = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(student => student.HomeTown == town);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }


        }
    }
}
