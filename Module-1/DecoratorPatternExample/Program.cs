using System;

class Program
{
    static void Main()
    {
        INotifier notifier =
            new SlackNotifierDecorator(
                new SMSNotifierDecorator(
                    new EmailNotifier()));

        notifier.Send("Server Down!");
    }
}