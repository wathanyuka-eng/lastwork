```mermaid
classDiagram
direction LR

class User {
    <<abstract>>
    - string Name
    + GetInfo() string
}

class Student {
    - string StudentID
    - int Score
    + GetInfo() string
    + GetGrade() string
}

class Course {
    - string CourseID
    - string CourseName
    - List~Student~ Students
    + AddStudent(Student s) void
    + ShowAllStudents() void
    + ShowMaxMin() void
    + ShowAverage() void
    + ShowReport() void
}

User <|-- Student : Inheritance
Course "1" --> "*" Student : Aggregation
