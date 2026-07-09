BEGIN TRY

    INSERT INTO Customers
    VALUES
    (1,'Rahul','North');

END TRY

BEGIN CATCH

    SELECT
        ERROR_NUMBER()     AS ErrorNumber,
        ERROR_MESSAGE()    AS ErrorMessage,
        ERROR_LINE()       AS ErrorLine,
        ERROR_PROCEDURE()  AS ErrorProcedure,
        ERROR_SEVERITY()   AS ErrorSeverity,
        ERROR_STATE()      AS ErrorState;

END CATCH;


BEGIN TRY

    SELECT 100/0;

END TRY

BEGIN CATCH

    SELECT
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_MESSAGE() AS ErrorMessage;

END CATCH;