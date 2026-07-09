DECLARE @ProductID INT;

DECLARE ProductCursor CURSOR
FOR
SELECT ProductID
FROM Products;


OPEN ProductCursor;

FETCH NEXT
FROM ProductCursor
INTO @ProductID;

WHILE @@FETCH_STATUS = 0
BEGIN

    UPDATE Products
    SET Price = Price + 100
    WHERE ProductID = @ProductID;

    FETCH NEXT
    FROM ProductCursor
    INTO @ProductID;

END;


CLOSE ProductCursor;


DEALLOCATE ProductCursor;

SELECT *
FROM Products;