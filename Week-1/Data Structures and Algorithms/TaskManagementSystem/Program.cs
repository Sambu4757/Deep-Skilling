using System;

class Program
{
    static void Main()
    {
        TaskLinkedList tasks =
            new TaskLinkedList();

        tasks.Add(
            new Task
            {
                TaskId = 1,
                TaskName = "Design UI",
                Status = "Pending"
            });

        tasks.Add(
            new Task
            {
                TaskId = 2,
                TaskName = "Develop Backend",
                Status = "In Progress"
            });

        tasks.Add(
            new Task
            {
                TaskId = 3,
                TaskName = "Testing",
                Status = "Pending"
            });

        tasks.Traverse();

        Console.WriteLine();

        tasks.Search(2);

        Console.WriteLine();

        tasks.Delete(1);

        tasks.Traverse();
    }
}