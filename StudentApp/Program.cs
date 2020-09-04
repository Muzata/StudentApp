using System;
public class Student
{
    int id;
    String name;
    int age;
    String egn;

    Student(int studentId, String studentName, int studentAge, String studentEgn)
    {
        id = studentId;
        name = studentName;
        age = studentAge;
        egn = studentEgn;
    }
        public static void printStudentInfo(Student student)
    {
        Console.WriteLine("=======================");
        Console.WriteLine("ID: " + student.id);
        Console.WriteLine("Name: " + student.name);
        Console.WriteLine("Age: " + student.age);
        Console.WriteLine("EGN: " + student.egn);
    }

    public static void checkIfYoungStudent(Student student)
    {
        if (student.age <= 25)
        {
            Console.WriteLine("--------");
            Console.WriteLine(student.name + " is young enough.");
            printStudentInfo(student);
            Console.WriteLine("--------");
        } else
        {
            Console.WriteLine(student.name + " is older than 25.");
        }
    }

    public static void Main(string[] args)
    {
        Student Student1 = new Student(101, "John Wick", 22, "9912232012");
        Student Student2 = new Student(102, "Peter Jonhson", 25, "9956870095");
        Student Student3 = new Student(103, "Koby Briant", 24, "9924242424");
        Student Student4 = new Student(104, "Travis Rice", 30, "9912232013");
        Student Student5 = new Student(105, "Dikembe Mutombo", 29, "9912232098");

        printStudentInfo(Student1);

        checkIfYoungStudent(Student3);

        checkIfYoungStudent(Student5);


    }
}