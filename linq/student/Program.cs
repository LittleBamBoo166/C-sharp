using System.Runtime.InteropServices;
using System.Linq;

class StudentClass
{
    public int ClassID267;
    public string ClassName267;

    public StudentClass(int classID267, string className267)
    {
        ClassID267 = classID267;
        ClassName267 = className267;
    }
}

class Student
{
    public int StudentID267, Age267;
    public string StudentName267;
    public StudentClass StudentClass267;

    public Student(int studentID267, int age267, string studentName267, StudentClass studentClass267)
    {
        StudentID267 = studentID267;
        Age267 = age267;
        StudentName267 = studentName267;
        StudentClass267 = studentClass267;
    }
}

class Program
{
    List<Student> students267 = new List<Student> {
        new Student (1, 18, "John", new StudentClass(1, "12A1")),
        new Student (2, 17, "Doe", new StudentClass(1, "11A3")),
        new Student (3, 16, "Steve", new StudentClass(1, "10B3")),
        new Student (4, 15, "Bill", new StudentClass(1, "9C4")),
        new Student (5, 18, "Ron", new StudentClass(1, "12B3")),
        new Student (6, 18, "Will", new StudentClass(1, "12A4")),
    };
    
    
}
