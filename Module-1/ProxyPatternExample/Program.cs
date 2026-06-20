using System;

class Program
{
    static void Main()
    {
        IImage image = new ProxyImage("Nature.jpg");

        Console.WriteLine("Image object created");

        Console.WriteLine();

        image.Display();

        Console.WriteLine();

        image.Display();
    }
}