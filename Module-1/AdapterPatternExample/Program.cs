using System;

class Program
{
    static void Main()
    {
        IPaymentProcessor payment1 =
            new PaytmAdapter(new PaytmGateway());

        payment1.ProcessPayment(1000);

        IPaymentProcessor payment2 =
            new RazorpayAdapter(new RazorpayGateway());

        payment2.ProcessPayment(2000);
    }
}
