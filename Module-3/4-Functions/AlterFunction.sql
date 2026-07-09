ALTER FUNCTION CalculateDiscount
(
    @Price DECIMAL(10,2),
    @DiscountPercentage DECIMAL(5,2)
)

RETURNS DECIMAL(10,2)

AS
BEGIN

    RETURN @Price - ((@Price * @DiscountPercentage) / 100);

END;

SELECT dbo.CalculateDiscount(1200,10) AS FinalPrice;

SELECT dbo.CalculateDiscount(800,15) AS FinalPrice;

SELECT
    ProductName,
    Price,
    dbo.CalculateDiscount(Price,20) AS FinalPrice
FROM Products;