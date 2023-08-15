using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public List<string> courses = new List<string>();
        public List<char> Grades = new List<char>();

        public List<string> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public void AddGrade(string course, char grade)
        {
            courses.Add(course);
            Grades.Add(grade);
        }

        public double Gpa
        {
            get
            {
                if (Grades.Count == 0)
                    return 0;
                double totalGradePoints = 0;
                foreach (char grade in Grades)
                { 
                    totalGradePoints += grade;
                    switch (grade)
                    {
                        case 'A':
                            totalGradePoints += 4;
                            break;
                        case 'B':
                            totalGradePoints += 3;
                            break;
                        case 'C':
                            totalGradePoints += 2;
                            break;
                        case 'D':
                            totalGradePoints += 1;
                            break;
                        case 'F':
                            totalGradePoints += 0;
                            break;
                        default:
                            totalGradePoints += 0;
                            break;
                        }
                }
                return totalGradePoints / Grades.Count;
            }
        }

        /*public Student(int id, string name, int age, string gender, List<string> course, List<string> grade)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Course = course;
            Grade = grade;
        }*/

        public override string ToString()
        {
            string courseList = courses != null ? string.Join(", ", courses) : "No courses enrolled";
            return $"ID: {id}, Name: {name}, Age: {age}, Gender: {gender}, Course: {courseList}, GPA:{Gpa:F2}";
        }

    }
}
