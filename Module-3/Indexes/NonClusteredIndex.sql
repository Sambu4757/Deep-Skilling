Use OnlineRetailStore;
SELECT *
FROM Products
WHERE ProductName='Tablet';

CREATE NONCLUSTERED INDEX IX_ProductName
ON Products(ProductName);


SELECT *
FROM Products
WHERE ProductName='Tablet';