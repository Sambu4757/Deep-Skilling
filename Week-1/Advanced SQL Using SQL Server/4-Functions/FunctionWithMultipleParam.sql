CREATE FUNCTION CalculateDiscount
(
    @Price DECIMAL(10,2),
    @DiscountPercentage DECIMAL(5,2)
)

RETURNS DECIMAL(10,2)

AS
BEGIN

    RETURN (@Price * @DiscountPercentage) / 100;

END;


SELECT dbo.CalculateDiscount(1200,10) AS Discount;

SELECT dbo.CalculateDiscount(800,15) AS Discount;


SELECT
    ProductName,
    Price,
    dbo.CalculateDiscount(Price,20) AS Discount
FROM Products;