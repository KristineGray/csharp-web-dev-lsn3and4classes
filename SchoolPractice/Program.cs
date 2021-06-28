using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student studentOne = new Student();
            studentOne.Name = "Kris";
            studentOne.StudentId = 1001;
            studentOne.NumberOfCredits = 1;
            studentOne.Gpa = 4.0;

            Student studentTwo = new Student();
            studentTwo.Name = "Bob";
            studentTwo.StudentId = 1002;

            Student studentThree = new Student();
            studentThree.Name = "Cody";
            studentThree.StudentId = 1003;

            Course programming = new Course();
            programming.Name = "Programming 101";
            programming.NumStudents = 3;

            List<Student> students = new List<Student> { studentOne, studentTwo, studentThree };
            foreach (Student student in students)
            {
                programming.AddStudent(student.StudentId, student.Name);
            }
            programming.PrintRoster();

            Teacher teacher = new Teacher();
            teacher.FirstName = "Roger";
            teacher.LastName = "Campbell";
            teacher.Subject = "Programming";
            teacher.YearsTeaching = 12; //Don't remember
            teacher.PrintTeacher();
            Console.ReadKey();
        }
    }
}
