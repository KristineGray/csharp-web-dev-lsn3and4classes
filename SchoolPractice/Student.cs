using System;
using System.Collections.Generic;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
    }

    public class Course
    {
        public string Name { get; set; }
        public int NumStudents { get; set; }
        public Dictionary<int, string> Roster = new Dictionary<int, string>();

        public void AddStudent(int studentID, string studentName)
        {
            this.Roster.Add(studentID, studentName);
            //Console.WriteLine($"Student #:{studentID} - {studentName} added to roster.");
        }
        public void PrintRoster()
        {
            Console.WriteLine($"\nThe student roster for {this.Name}:");
            foreach (KeyValuePair <int, string> student in Roster)
                Console.WriteLine($"Student ID #{student.Key} - Name: {student.Value}");
        }
    }

    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public void PrintTeacher()
        {
            Console.WriteLine($"\n{FirstName} {LastName} teaches {Subject} and has {YearsTeaching} years of experience.");
        }
    }
}
