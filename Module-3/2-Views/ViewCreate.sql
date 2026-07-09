CREATE VIEW CustomerOrdersView
AS
SELECT
    C.CustomerID,
    C.Name,
    C.Region,
    O.OrderID,
    O.OrderDate
FROM Customers C
INNER JOIN Orders O
ON C.CustomerID = O.CustomerID;

SELECT *
FROM CustomerOrdersView;