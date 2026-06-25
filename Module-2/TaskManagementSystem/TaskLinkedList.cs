using System;

public class TaskLinkedList
{
    private Node? head;

    public void Add(Task task)
    {
        Node newNode = new Node(task);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public void Search(int id)
    {
        Node? current = head;

        while (current != null)
        {
            if (current.Data.TaskId == id)
            {
                Console.WriteLine(
                    $"Task Found : {current.Data.TaskName}");
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Task Not Found");
    }

    public void Traverse()
    {
        Node? current = head;

        Console.WriteLine("\nTask List");

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Data.TaskId} " +
                $"{current.Data.TaskName} " +
                $"{current.Data.Status}");

            current = current.Next;
        }
    }

    public void Delete(int id)
    {
        if (head == null)
            return;

        if (head.Data.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task Deleted");
            return;
        }

        Node current = head;

        while (current.Next != null &&
               current.Next.Data.TaskId != id)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Task Deleted");
        }
        else
        {
            Console.WriteLine("Task Not Found");
        }
    }
}