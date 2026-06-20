public abstract class NotifierDecorator : INotifier
{
    protected INotifier notifier;

    public NotifierDecorator(INotifier notifier)
    {
        this.notifier = notifier;
    }

    public virtual void Send(string message)
    {
        notifier.Send(message);
    }
}