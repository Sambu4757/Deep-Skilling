CREATE FUNCTION CalculateGST
(
    @Price DECIMAL(10,2)
)

RETURNS DECIMAL(10,2)

AS

BEGIN

    RETURN @Price * 0.18;

END;

SELECT dbo.CalculateGST(1200.00) AS GST;

SELECT
    ProductName,
    Price,
    dbo.CalculateGST(Price) AS GST
FROM Products;