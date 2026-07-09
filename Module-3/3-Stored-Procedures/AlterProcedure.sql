ALTER PROCEDURE GetCustomerById
    @CustomerID INT
AS
BEGIN

    SELECT
        C.CustomerID,
        C.Name,
        C.Region,
        O.OrderID,
        O.OrderDate
    FROM Customers C
    INNER JOIN Orders O
        ON C.CustomerID = O.CustomerID
    WHERE C.CustomerID = @CustomerID;

END;

EXEC GetCustomerById 1;

EXEC GetCustomerById 2;