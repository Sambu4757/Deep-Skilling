public class PaytmAdapter : IPaymentProcessor
{
    private PaytmGateway paytm;

    public PaytmAdapter(PaytmGateway paytm)
    {
        this.paytm = paytm;
    }

    public void ProcessPayment(double amount)
    {
        paytm.MakePayment(amount);
    }
}