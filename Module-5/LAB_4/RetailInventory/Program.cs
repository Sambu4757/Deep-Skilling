using RetailInventory.Data;
using RetailInventory.Models;

using var context = new InventoryContext();

// Step 1: Create Category and Product objects
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);

var product1 = new Product
{
    Name = "Laptop",
    Price = 75000,
    Category = electronics
};

var product2 = new Product
{
    Name = "Rice Bag",
    Price = 1200,
    Category = groceries
};

await context.Products.AddRangeAsync(product1, product2);

// Step 2: Save the changes to the database
await context.SaveChangesAsync();

Console.WriteLine("Data inserted successfully.");
