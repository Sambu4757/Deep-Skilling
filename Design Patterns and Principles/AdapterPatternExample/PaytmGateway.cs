using System;

public class PaytmGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paytm Payment: ₹{amount}");
    }
}