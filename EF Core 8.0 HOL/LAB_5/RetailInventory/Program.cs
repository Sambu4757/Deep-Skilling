using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

using var context = new InventoryContext();

// --- Data seeded in Lab 4 (kept here so this lab runs standalone) ---
if (!await context.Categories.AnyAsync())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    await context.Categories.AddRangeAsync(electronics, groceries);

    await context.Products.AddRangeAsync(
        new Product { Name = "Laptop", Price = 75000, Category = electronics },
        new Product { Name = "Rice Bag", Price = 1200, Category = groceries }
    );

    await context.SaveChangesAsync();
}

// Step 1: Retrieve all products
var products = await context.Products.ToListAsync();

Console.WriteLine("All Products");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - \u20b9{p.Price}");
}

// Step 2: Retrieve product by Id
var product = await context.Products.FindAsync(1);
Console.WriteLine($"\nFound Product: {product?.Name}");

// Step 3: Retrieve product using a condition
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"\nExpensive Product: {expensive?.Name}");
