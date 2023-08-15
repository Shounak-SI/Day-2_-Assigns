using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    internal class School
    {

        List<Student> students;
        
        public School() {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudentList()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
                /*Console.WriteLine($"Name: {student.name}, Age: {student.age}, Gender: {student.gender}");
                Console.WriteLine("Courses Enrolled:");
                foreach (string course in student.courses)
                {
                    Console.WriteLine(course);
                }
                Console.WriteLine($"GPA: {student.Gpa:F2}\n");*/
            }
        }

        public double CalculateAllGPA()
        {
            if (students.Count == 0)
                return 0;

            double totalGPA = 0;
            foreach (Student student in students)
            {
                totalGPA += student.Gpa;
            }

            return totalGPA / students.Count;
        }
    }
}
