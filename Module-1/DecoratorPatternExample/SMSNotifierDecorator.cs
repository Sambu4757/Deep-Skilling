using System;

public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(INotifier notifier)
        : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);

        Console.WriteLine($"SMS Sent: {message}");
    }
}