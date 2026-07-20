USE OnlineRetailStore;

BEGIN TRY

    INSERT INTO Customers
    VALUES
    (1,'Rahul','North');

END TRY

BEGIN CATCH

    PRINT 'An error occurred.';

END CATCH;




BEGIN TRY

SELECT 100/0;

END TRY

BEGIN CATCH

PRINT 'Division by Zero Error';

END CATCH;