# LAB 3: Using EF Core CLI to Create and Apply Migrations

## Aim
Use the Entity Framework Core CLI to create and apply database migrations
in SQL Server.

## Objective
- Install the EF Core CLI tool.
- Create an initial migration.
- Apply the migration to create the database.
- Verify the database and tables in SQL Server.

## Tools required
- Visual Studio Code
- .NET SDK
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Entity Framework Core

## Procedure

### Step 1: Install EF Core CLI
```bash
dotnet tool install --global dotnet-ef
```

### Step 2: Create initial migration
```bash
dotnet ef migrations add InitialCreate
```
This generates the `Migrations/` folder with the migration files.

> **Note:** If `InitialCreate` already exists, list existing migrations
> instead of re-creating it:
> ```bash
> dotnet ef migrations list
> ```
> Example output:
> ```
> 20260703151156_InitialCreate
> 20260703153717_UpdateModels
> ```

### Step 3: Apply migration
```bash
dotnet ef database update
```
This creates/updates the `RetailInventoryDB` database in SQL Server. If
already up to date:
```
No migrations were applied. The database is already up to date.
Done.
```

### Step 4: Verify database
Opened SQL Server Management Studio (SSMS) and confirmed the database and
tables (`Categories`, `Products`, `__EFMigrationsHistory`) were created
successfully.

## Result
The Entity Framework Core migration was successfully created and applied.
The `RetailInventoryDB` database and the required tables were successfully
created in SQL Server.

## Run it
```bash
dotnet restore
dotnet ef migrations list
dotnet ef database update
```

The application code (`Models/`, `Data/InventoryContext.cs`, `Program.cs`)
is unchanged from Lab 2 — this lab focuses on the EF Core CLI workflow.
