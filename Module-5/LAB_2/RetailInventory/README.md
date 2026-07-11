# LAB 2: Setting Up the Database Context for a Retail Store

## Aim
Configure the Entity Framework Core DbContext and connect a .NET Console
Application to SQL Server.

## Objective
- Create `Product` and `Category` models.
- Configure `DbContext`.
- Connect the application to SQL Server.
- Generate and apply database migrations.

## Tools required
- Visual Studio Code
- .NET SDK
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Entity Framework Core

## Procedure

### Step 1: Create entity models
`Product` and `Category` model classes were created with a one-to-many
relationship (`Models/Category.cs`, `Models/Product.cs`).

### Step 2: Configure DbContext
`InventoryContext` (`Data/InventoryContext.cs`) inherits from `DbContext` and
exposes `DbSet<Product> Products` and `DbSet<Category> Categories`.

### Step 3: Configure SQL Server connection
The connection is configured via `UseSqlServer()` inside `OnConfiguring`:

```csharp
optionsBuilder.UseSqlServer(
    @"Server=localhost\SQLEXPRESS;Database=RetailInventoryDB;Trusted_Connection=True;TrustServerCertificate=True;");
```

> Update the connection string to match your local SQL Server instance name.

### Step 4: Create migration
```bash
dotnet ef migrations add UpdateModels
```

### Step 5: Update database
```bash
dotnet ef database update
```

### Step 6: Verify database
Confirmed in SSMS that the `Products` and `Categories` tables were created
under the `RetailInventoryDB` database.

## Result
The database context was successfully configured using Entity Framework
Core. The `Product` and `Category` tables were created in SQL Server, and
the application was successfully connected to the database.

## Run it
```bash
dotnet tool install --global dotnet-ef   # first time only
dotnet restore
dotnet ef migrations add UpdateModels
dotnet ef database update
dotnet run
```
