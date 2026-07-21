USE OnlineRetailStore;


DROP TRIGGER trg_AfterInsertCustomer;


INSERT INTO Customers
VALUES
(8,'Sophia','East');



SELECT *
FROM CustomerAudit;