CREATE PROCEDURE GetCustomerById
    @CustomerID INT
AS
BEGIN

    SELECT *
    FROM Customers
    WHERE CustomerID = @CustomerID;

END;

EXEC GetCustomerById 1;

EXEC GetCustomerById 3;