CREATE TRIGGER trg_AfterInsertCustomer

ON Customers

AFTER INSERT

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
        'INSERT',
        GETDATE()

    FROM inserted;

END;

INSERT INTO Customers
VALUES
(5,'Emma','Central');

SELECT *
FROM CustomerAudit;