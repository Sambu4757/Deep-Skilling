# LAB 1: Understanding ORM with a Retail Inventory System

## Aim
Understand Object Relational Mapping (ORM), learn Entity Framework Core, and
connect a .NET Console Application to SQL Server using Entity Framework Core.

## What is ORM?
Object Relational Mapping (ORM) maps C# classes to relational database
tables, letting developers perform database operations using C# objects
instead of writing SQL manually. EF Core converts C# code into SQL
statements and maps returned data back into C# objects.

| C# side          | Database side  |
|-------------------|----------------|
| Class              | Table          |
| Class properties   | Table columns  |
| Object             | Table row      |

## Benefits of ORM
1. **Productivity** — CRUD via C# objects instead of hand-written SQL.
2. **Maintainability** — model changes sync to the DB via EF Core Migrations.
3. **Abstraction from SQL** — LINQ queries are auto-translated to SQL.

## EF Core vs EF6

| Entity Framework Core        | Entity Framework (EF6)     |
|-------------------------------|------------------------------|
| Cross-platform                 | Windows only                 |
| Lightweight                    | Comparatively heavier        |
| Better performance             | Mature framework             |
| Supports LINQ                  | Supports LINQ                |
| Supports Async Queries         | Limited async support        |
| Supports Compiled Queries      | Limited support              |
| Supports modern .NET versions  | Supports .NET Framework      |

## EF Core 8.0 highlights
- **JSON Column Mapping** — store complex objects as JSON columns.
- **Compiled Models** — faster startup via generated optimized models.
- **Interceptors** — custom logic before/after DB operations.
- **Improved Bulk Operations** — faster insert/update/delete at scale.

## Steps performed

```bash
dotnet new console -n RetailInventory
cd RetailInventory

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Software requirements
- Visual Studio Code / Visual Studio 2022
- .NET SDK (8.0)
- SQL Server 2022 Express
- SQL Server Management Studio (SSMS)
- Entity Framework Core packages

## Result
The RetailInventory console application was created and the required EF Core
packages were installed successfully. DbContext and SQL Server connection
setup follows in Lab 2.
