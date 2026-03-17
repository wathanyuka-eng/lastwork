using System;
using System.Collections.Generic;

namespace GradeSystem
{
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

        public Course(string id, string name)
        {
            CourseID = id;
            CourseName = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        // 📋 แสดงนักศึกษาทั้งหมด
        public void ShowAllStudents()
        {
            Console.WriteLine($"\n=== {CourseID} - {CourseName} ===");

            if (Students.Count == 0)
            {
                Console.WriteLine("No students!");
                return;
            }

            foreach (var s in Students)
            {
                Console.WriteLine(s.GetInfo());
            }
        }

        // 🏆 คะแนนสูงสุด / ต่ำสุด + คนที่ได้
        public void ShowMaxMin()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No data!");
                return;
            }

            Student maxStudent = Students[0];
            Student minStudent = Students[0];

            foreach (var s in Students)
            {
                if (s.Score > maxStudent.Score)
                    maxStudent = s;

                if (s.Score < minStudent.Score)
                    minStudent = s;
            }

            Console.WriteLine("\n=== Max Score ===");
            Console.WriteLine(maxStudent.GetInfo());

            Console.WriteLine("\n=== Min Score ===");
            Console.WriteLine(minStudent.GetInfo());
        }

        // 📊 ค่าเฉลี่ย
        public void ShowAverage()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No data!");
                return;
            }

            int sum = 0;

            foreach (var s in Students)
            {
                sum += s.Score;
            }

            double avg = (double)sum / Students.Count;

            Console.WriteLine($"\nAverage Score: {avg:F2}");
        }

        // 🔥 รวมทุกอย่าง (อาจารย์ชอบ)
        public void ShowReport()
        {
            ShowAllStudents();
            ShowMaxMin();
            ShowAverage();
        }
    }
}