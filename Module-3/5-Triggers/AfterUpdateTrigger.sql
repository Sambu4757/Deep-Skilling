CREATE TRIGGER trg_AfterUpdateCustomer

ON Customers

AFTER UPDATE

AS

BEGIN

    INSERT INTO CustomerAudit
    (
        CustomerID,
        ActionPerformed,
        ActionDate
    )

    SELECT
        CustomerID,
        'UPDATE',
        GETDATE()

    FROM inserted;

END;


UPDATE Customers
SET Region='Central'
WHERE CustomerID=2;


SELECT *
FROM CustomerAudit;