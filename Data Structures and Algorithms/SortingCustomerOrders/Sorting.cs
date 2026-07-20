using System;

public class Sorting
{
    // Bubble Sort
    public static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    // Quick Sort
    public static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(orders, low, high);

            QuickSort(orders, low, pivot - 1);

            QuickSort(orders, pivot + 1, high);
        }
    }

    private static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;

        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;

        return i + 1;
    }

    public static void Display(Order[] orders)
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(
                $"{order.OrderId}  " +
                $"{order.CustomerName}  " +
                $"₹{order.TotalPrice}");
        }

        Console.WriteLine();
    }
}