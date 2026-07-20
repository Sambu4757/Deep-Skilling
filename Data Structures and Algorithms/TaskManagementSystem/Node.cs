public class Node
{
    public Task Data { get; set; }

    public Node? Next { get; set; }

    public Node(Task task)
    {
        Data = task;
        Next = null;
    }
}