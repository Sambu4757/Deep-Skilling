using System;

public class Logger
{
    private static Logger instance;

    private Logger()
    {
        Console.WriteLine("Logger Created");
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}