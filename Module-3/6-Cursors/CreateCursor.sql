DECLARE @CustomerName VARCHAR(100);

DECLARE CustomerCursor CURSOR
FOR

SELECT Name
FROM Customers;


OPEN CustomerCursor;


FETCH NEXT
FROM CustomerCursor
INTO @CustomerName;

WHILE @@FETCH_STATUS = 0
BEGIN

    PRINT @CustomerName;

    FETCH NEXT
    FROM CustomerCursor
    INTO @CustomerName;

END;

CLOSE CustomerCursor;
DEALLOCATE CustomerCursor;