using System;
using System.Collections.Generic;
using System.Linq;

namespace PL04.Students
{

    class Student
    {
        public Student(string firstName, string secondName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
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

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                bool doesStudentExsist = DoesStudentExist(students, firstName, lastName);

                if (doesStudentExsist)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);

                    //Student existingStudent = students.FirstOrDefault(student => student.FirstName == firstName && student.LastName == lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;

                }
                else
                {
                    Student newStudent = new Student(
                   firstName,
                   lastName,
                   age,
                   homeTown);

                    students.Add(newStudent);
                }


                command = Console.ReadLine();
            }

            string town = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(student => student.HomeTown == town);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }


        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;

        }
    }
}
