using System;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(
            new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Quantity = 10,
                Price = 50000
            });

        inventory.AddProduct(
            new Product
            {
                ProductId = 2,
                ProductName = "Mouse",
                Quantity = 30,
                Price = 500
            });

        inventory.DisplayProducts();

        inventory.UpdateProduct(2, 50);

        inventory.DeleteProduct(1);

        inventory.DisplayProducts();
    }
}