using RetailInventory.Data;

using var context = new InventoryContext();

// Ensures the app can talk to the configured SQL Server database.
Console.WriteLine("Connecting to RetailInventoryDB...");
Console.WriteLine("DbContext configured with Products and Categories DbSets.");
