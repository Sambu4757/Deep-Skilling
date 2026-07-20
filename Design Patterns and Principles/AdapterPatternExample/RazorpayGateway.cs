using System;

public class RazorpayGateway
{
    public void PayAmount(double amount)
    {
        Console.WriteLine($"Razorpay Payment: ₹{amount}");
    }
}