using System;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Keyboard",
                Category = "Electronics"
            },

            new Product
            {
                ProductId = 2,
                ProductName = "Laptop",
                Category = "Electronics"
            },

            new Product
            {
                ProductId = 3,
                ProductName = "Mouse",
                Category = "Electronics"
            },

            new Product
            {
                ProductId = 4,
                ProductName = "Phone",
                Category = "Mobiles"
            }
        };

        Console.WriteLine("Linear Search:");

        Product? product =
            SearchOperations.LinearSearch(products, "Mouse");

        if (product != null)
        {
            Console.WriteLine(
                $"{product.ProductId} - {product.ProductName}");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        product =
            SearchOperations.BinarySearch(products, "Mouse");

        if (product != null)
        {
            Console.WriteLine(
                $"{product.ProductId} - {product.ProductName}");
        }
    }
}