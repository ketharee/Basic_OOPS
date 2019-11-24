using System;
using System.Collections.Generic;
namespace Basic_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> objStudents = new List<Student>();

            objStudents.Add(new Student().SetStudentInfo(101, "Arun"));
            objStudents.Add(new Student().SetStudentInfo(102, "Bala"));
            objStudents.Add(new Student().SetStudentInfo(103, "Chandru"));

            foreach (Student student in objStudents)
            {
                Console.WriteLine(student.Rollnumber);
                Console.WriteLine(student.Name);
            }
            
            
            Console.ReadLine();
        }
    }
}
