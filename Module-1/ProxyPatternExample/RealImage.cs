using System;

public class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadFromServer();
    }

    private void LoadFromServer()
    {
        Console.WriteLine($"Loading {fileName} from server...");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {fileName}");
    }
}   