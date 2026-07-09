USE OnlineRetailStore;

SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2023-01-15';

CREATE NONCLUSTERED INDEX IX_Customer_OrderDate
ON Orders(CustomerID, OrderDate);

SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2023-01-15';

SELECT
    name,
    type_desc
FROM sys.indexes
WHERE object_id = OBJECT_ID('Orders');