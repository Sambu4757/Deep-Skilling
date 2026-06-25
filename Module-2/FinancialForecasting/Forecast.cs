using System;

public class Forecast
{
    public static double PredictFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {
        if (years == 0)
        {
            return currentValue;
        }

        return PredictFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1);
    }
}