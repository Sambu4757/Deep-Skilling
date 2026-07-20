USE OnlineRetailStore;


--------------------------------------------------
    --Query Before Creating Clustered Index
--------------------------------------------------

SELECT *
FROM Orders
WHERE OrderDate = '2023-01-15';


-- Step 2 : Check Existing Indexes

SELECT
    name,
    type_desc
FROM sys.indexes
WHERE object_id = OBJECT_ID('Orders');
GO


--  Query After Verification

SELECT *
FROM Orders
WHERE OrderDate = '2023-01-15';