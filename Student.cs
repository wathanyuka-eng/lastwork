namespace GradeSystem
{
    class Student : User
    {
        public string StudentID { get; set; }
        public int Score { get; set; } // 🔥 คะแนนวิชานั้น (ตัวเดียว)

        public Student(string name, string id, int score) : base(name)
        {
            StudentID = id;
            Score = score;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, ID: {StudentID}, Score: {Score}, Grade: {GetGrade()}";
        }

        public string GetGrade()
        {
            if (Score >= 80) return "A";
            else if (Score >= 75) return "B+";
            else if (Score >= 70) return "B";
            else if (Score >= 65) return "C+";
            else if (Score >= 60) return "C";
            else if (Score >= 55) return "D+";
            else if (Score >= 50) return "D";
            else return "F";
        }
    }
}