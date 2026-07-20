using System;
using System.Collections.Generic;

public class StockMarket : IStock
{
    private List<IObserver> observers =
        new List<IObserver>();

    private double stockPrice;

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockPrice);
        }
    }

    public void SetStockPrice(double price)
    {
        stockPrice = price;

        Console.WriteLine(
            $"Stock Price Updated: ₹{stockPrice}");

        NotifyObservers();
    }
}