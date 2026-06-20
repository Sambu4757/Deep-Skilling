using System;

public class MobileApp : IObserver
{
    public void Update(double stockPrice)
    {
        Console.WriteLine(
            $"Mobile App: New Price ₹{stockPrice}");
    }
}