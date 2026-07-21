using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<int, Product> products =
        new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        products[product.ProductId] = product;

        Console.WriteLine("Product Added");
    }

    public void UpdateProduct(int id, int quantity)
    {
        if (products.ContainsKey(id))
        {
            products[id].Quantity = quantity;

            Console.WriteLine("Product Updated");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    public void DeleteProduct(int id)
    {
        if (products.Remove(id))
        {
            Console.WriteLine("Product Deleted");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("\nInventory:");

        foreach (var product in products.Values)
        {
            Console.WriteLine(
                $"{product.ProductId}  " +
                $"{product.ProductName}  " +
                $"{product.Quantity}  " +
                $"₹{product.Price}");
        }
    }
}