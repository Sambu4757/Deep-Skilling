public class PaymentContext
{
    private IPaymentStrategy strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void MakePayment(double amount)
    {
        strategy.Pay(amount);
    }
}