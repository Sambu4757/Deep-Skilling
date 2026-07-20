public class RazorpayAdapter : IPaymentProcessor
{
    private RazorpayGateway razorpay;

    public RazorpayAdapter(RazorpayGateway razorpay)
    {
        this.razorpay = razorpay;
    }

    public void ProcessPayment(double amount)
    {
        razorpay.PayAmount(amount);
    }
}