# LAB 4: Inserting Initial Data into the Database

## Aim
Insert initial data into the SQL Server database using Entity Framework Core.

## Objective
- Create category and product objects.
- Insert records using `AddRangeAsync()`.
- Save data using `SaveChangesAsync()`.
- Verify the inserted data in SQL Server.

## Tools required
- Visual Studio Code
- .NET SDK
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Entity Framework Core

## Procedure

### Step 1: Create Category and Product objects
`Category` and `Product` objects were created with sample values in
`Program.cs`.

### Step 2: Insert data
```csharp
await context.Categories.AddRangeAsync(electronics, groceries);

await context.Products.AddRangeAsync(product1, product2);

await context.SaveChangesAsync();
```

### Step 3: Run the application
```bash
dotnet run
```
Output:
```
Data inserted successfully.
```

### Step 4: Verify the data
Verified in SSMS — `Categories` table:

| Id | Name        |
|----|-------------|
| 1  | Electronics |
| 2  | Groceries   |

`Products` table:

| Id | Name     | Price    | CategoryId |
|----|----------|----------|------------|
| 1  | Laptop   | 75000.00 | 1          |
| 2  | Rice Bag | 1200.00  | 2          |

## Result
The initial category and product records were successfully inserted into
the SQL Server database using Entity Framework Core. The inserted data was
verified successfully in SQL Server Management Studio (SSMS).

## Run it
```bash
dotnet restore
dotnet ef database update   # ensure schema is up to date (see Lab 2/3)
dotnet run
```
