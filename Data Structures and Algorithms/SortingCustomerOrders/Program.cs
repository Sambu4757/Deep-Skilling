using System;

class Program
{
    static void Main()
    {
        Order[] orders =
        {
            new Order
            {
                OrderId = 1,
                CustomerName = "Rahul",
                TotalPrice = 2500
            },

            new Order
            {
                OrderId = 2,
                CustomerName = "Anita",
                TotalPrice = 1000
            },

            new Order
            {
                OrderId = 3,
                CustomerName = "Kiran",
                TotalPrice = 4500
            },

            new Order
            {
                OrderId = 4,
                CustomerName = "Suresh",
                TotalPrice = 1800
            }
        };

        Console.WriteLine("Bubble Sort:");

        Sorting.BubbleSort(orders);

        Sorting.Display(orders);

        orders =
        new Order[]
        {
            new Order { OrderId=1, CustomerName="Rahul", TotalPrice=2500 },
            new Order { OrderId=2, CustomerName="Anita", TotalPrice=1000 },
            new Order { OrderId=3, CustomerName="Kiran", TotalPrice=4500 },
            new Order { OrderId=4, CustomerName="Suresh", TotalPrice=1800 }
        };

        Console.WriteLine("Quick Sort:");

        Sorting.QuickSort(orders, 0, orders.Length - 1);

        Sorting.Display(orders);
    }
}