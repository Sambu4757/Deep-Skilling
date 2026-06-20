using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();

        Logger logger2 = Logger.GetInstance();

        logger1.Log("Application Started");

        logger2.Log("User Logged In");

        Console.WriteLine("Same Object? " + (logger1 == logger2));

        Console.WriteLine("Logger1 HashCode: " + logger1.GetHashCode());

        Console.WriteLine("Logger2 HashCode: " + logger2.GetHashCode());
    }
}