using System;

namespace GradeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = null;
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Create Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Show All Students");
                Console.WriteLine("4. Show Report");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        course = CreateCourse();
                        break;

                    case "2":
                        if (course == null)
                            Console.WriteLine("Please create course first!");
                        else
                            AddStudent(course);
                        break;

                    case "3":
                        if (course == null)
                            Console.WriteLine("No course!");
                        else
                            course.ShowAllStudents();
                        break;

                    case "4":
                        if (course == null)
                            Console.WriteLine("No course!");
                        else
                            course.ShowReport();
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        running = false; // ออกจาก loop
                        break;

                    default:
                        Console.WriteLine("Invalid menu, try again!");
                        break;
                }
            }
        }

        static Course CreateCourse()
        {
            Console.Write("Enter Course ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Course created!");
            return new Course(id, name);
        }

        static void AddStudent(Course course)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student ID: ");
            string id = Console.ReadLine();

            int score;
            while (true)
            {
                Console.Write("Enter score: ");
                if (int.TryParse(Console.ReadLine(), out score))
                    break;

                Console.WriteLine("Please enter a valid number!");
            }

            Student s = new Student(name, id, score);
            course.AddStudent(s);

            Console.WriteLine("Added!");
        }
    }
}