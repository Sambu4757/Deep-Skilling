USE OnlineRetailStore;


CREATE TRIGGER trg_AfterDeleteCustomer

ON Customers

AFTER DELETE

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
        'DELETE',
        GETDATE()

    FROM deleted;

END;

DELETE FROM Customers
WHERE CustomerID = 5;

SELECT *
FROM CustomerAudit;