using System;

public class StudentView
{
    public void DisplayStudentDetails(
        string name,
        int id,
        string grade)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"ID   : {id}");
        Console.WriteLine($"Grade: {grade}");
    }
}