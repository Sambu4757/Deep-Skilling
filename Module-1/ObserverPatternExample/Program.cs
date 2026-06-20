using System;

class Program
{
    static void Main()
    {
        StockMarket stockMarket =
            new StockMarket();

        IObserver mobile =
            new MobileApp();

        IObserver web =
            new WebApp();

        stockMarket.RegisterObserver(mobile);
        stockMarket.RegisterObserver(web);

        stockMarket.SetStockPrice(1000);

        Console.WriteLine();

        stockMarket.SetStockPrice(1200);
    }
}