namespace StudentRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            while (true)
            {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Display Student List");
                    Console.WriteLine("3. Calculate Overall GPA");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Student student = new Student();
                            Console.Write("Enter student Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name of student: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter student age: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Enter student gender: ");
                            string gender = Console.ReadLine();
                            
                            Console.Write("Enter number of courses enrolled: ");

                            int numCourses = int.Parse(Console.ReadLine());                           
                            for (int i = 0; i < numCourses; i++)
                            {
                                Console.WriteLine($"Enter course {i + 1}: ");
                                string course = Console.ReadLine();
                                Console.Write($"Enter grade (A, B, C, D, F) for course {i + 1}: ");
                                char grade = char.ToUpper(Console.ReadLine()[0]);
                                student.AddGrade(course, grade);                        
                            }
                            school.AddStudent(student);
                            Console.WriteLine("Student added successfully");
                            break;
                        case 2:
                            school.DisplayStudentList();
                            break;
                        case 3:
                            double result = school.CalculateAllGPA();
                            Console.WriteLine(result);
                            break;
                        case 4:
                        return;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
            }             
        }
    }
}