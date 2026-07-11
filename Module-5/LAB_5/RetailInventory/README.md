# LAB 5: Retrieving Data from the Database

## Aim
Retrieve data from the SQL Server database using Entity Framework Core.

## Objective
- Retrieve all records using `ToListAsync()`.
- Retrieve a record by its primary key using `FindAsync()`.
- Retrieve a record based on a condition using `FirstOrDefaultAsync()`.

## Tools required
- Visual Studio Code
- .NET SDK
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Entity Framework Core

## Procedure

### Step 1: Retrieve all products
```csharp
var products = await context.Products.ToListAsync();
```

### Step 2: Retrieve product by Id
```csharp
var product = await context.Products.FindAsync(1);
```

### Step 3: Retrieve product using a condition
```csharp
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);
```

### Step 4: Run the application
```bash
dotnet run
```
Expected output:
```
All Products
Laptop - 75000.00
Rice Bag - 1200.00

Found Product: Laptop

Expensive Product: Laptop
```

### Step 5: Verify the data
Verified the `Products` table records in SQL Server Management Studio (SSMS).

## Methods used

| Method                   | Purpose                                              |
|--------------------------|-------------------------------------------------------|
| `ToListAsync()`           | Retrieves all records from a table.                   |
| `FindAsync()`              | Retrieves a record using its primary key.              |
| `FirstOrDefaultAsync()`    | Retrieves the first record matching a condition.       |

## Result
The product data was successfully retrieved from the SQL Server database
using `ToListAsync()`, `FindAsync()`, and `FirstOrDefaultAsync()` methods in
Entity Framework Core.

## Run it
```bash
dotnet restore
dotnet ef database update   # ensure schema exists (Lab 2/3)
dotnet run
```

> This `Program.cs` seeds the Lab 4 data automatically if the database is
> empty, so the lab can be run standalone from a fresh database.
