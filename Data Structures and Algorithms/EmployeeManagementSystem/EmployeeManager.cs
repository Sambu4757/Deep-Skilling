using System;

public class EmployeeManager
{
    private Employee[] employees;

    private int count = 0;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
    }

    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;

            Console.WriteLine("Employee Added");
        }
        else
        {
            Console.WriteLine("Array Full");
        }
    }

    public void SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                Console.WriteLine(
                    $"Found : {employees[i].Name}");
                return;
            }
        }

        Console.WriteLine("Employee Not Found");
    }

    public void Traverse()
    {
        Console.WriteLine("\nEmployee List");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                $"{employees[i].EmployeeId} " +
                $"{employees[i].Name} " +
                $"{employees[i].Position} " +
                $"₹{employees[i].Salary}");
        }
    }

    public void DeleteEmployee(int id)
    {
        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee Not Found");
            return;
        }

        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[count - 1] = null!;

        count--;

        Console.WriteLine("Employee Deleted");
    }
}