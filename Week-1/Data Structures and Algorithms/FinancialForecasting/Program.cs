using System;

class Program
{
    static void Main()
    {
        double currentValue = 10000;

        double growthRate = 0.10;

        int years = 5;

        double futureValue =
            Forecast.PredictFutureValue(
                currentValue,
                growthRate,
                years);

        Console.WriteLine(
            $"Future Value after {years} years = ₹{futureValue:F2}");
    }
}