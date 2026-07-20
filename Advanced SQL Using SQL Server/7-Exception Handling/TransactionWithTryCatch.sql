BEGIN TRANSACTION;

BEGIN TRY


    INSERT INTO Customers
    VALUES
    (10,'Kevin','North');

    INSERT INTO Customers
    VALUES
    (10,'Kevin','North');

    COMMIT TRANSACTION;

END TRY

BEGIN CATCH

    ROLLBACK TRANSACTION;

    PRINT 'Transaction Rolled Back';

    SELECT
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_MESSAGE() AS ErrorMessage;

END CATCH;


BEGIN TRANSACTION;

BEGIN TRY

    INSERT INTO Customers
    VALUES
    (11,'Ravi','South');

    COMMIT TRANSACTION;

END TRY

BEGIN CATCH

    ROLLBACK TRANSACTION;

END CATCH;

SELECT *
FROM Customers
WHERE CustomerID = 11;