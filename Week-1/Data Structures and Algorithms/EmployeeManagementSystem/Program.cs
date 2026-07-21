using System;

class Program
{
    static void Main()
    {
        EmployeeManager manager =
            new EmployeeManager(5);

        manager.AddEmployee(
            new Employee
            {
                EmployeeId = 101,
                Name = "Sambu",
                Position = "Developer",
                Salary = 60000
            });

        manager.AddEmployee(
            new Employee
            {
                EmployeeId = 102,
                Name = "Rahul",
                Position = "Tester",
                Salary = 45000
            });

        manager.Traverse();

        Console.WriteLine();

        manager.SearchEmployee(102);

        Console.WriteLine();

        manager.DeleteEmployee(101);

        manager.Traverse();
    }
}