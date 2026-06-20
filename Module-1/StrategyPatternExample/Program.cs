using System;

class Program
{
    static void Main()
    {
        PaymentContext payment =
            new PaymentContext(
                new CreditCardPayment());

        payment.MakePayment(5000);

        payment.SetStrategy(
            new PayPalPayment());

        payment.MakePayment(2500);
    }
}