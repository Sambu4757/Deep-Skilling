using System;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine(
            $"Paid ₹{amount} using Credit Card");
    }
}