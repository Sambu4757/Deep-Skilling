CREATE PROCEDURE GetAllCustomers
AS
BEGIN

    SELECT *
    FROM Customers;

END;

EXEC GetAllCustomers;