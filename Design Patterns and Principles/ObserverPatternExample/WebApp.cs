using System;

public class WebApp : IObserver
{
    public void Update(double stockPrice)
    {
        Console.WriteLine(
            $"Web App: New Price ₹{stockPrice}");
    }
}