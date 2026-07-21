using System;

class Program
{
    static void Main()
    {
        Student student =
            new Student
            {
                Name = "Sambu",
                Id = 101,
                Grade = "A"
            };

        StudentView view =
            new StudentView();

        StudentController controller =
            new StudentController(
                student,
                view);

        controller.UpdateView();

        Console.WriteLine();

        controller.SetStudentName("Ravi");

        controller.SetStudentGrade("A+");

        controller.UpdateView();
    }
}