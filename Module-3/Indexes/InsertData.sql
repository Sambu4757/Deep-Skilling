INSERT INTO Customers(CustomerID,Name,Region)
VALUES
(1,'Alice','North'),
(2,'Bob','South'),
(3,'Charlie','East'),
(4,'David','West');

INSERT INTO Products(ProductID,ProductName,Category,Price)
VALUES
(1,'Laptop','Electronics',1200),
(2,'Smartphone','Electronics',800),
(3,'Tablet','Electronics',600),
(4,'Headphones','Accessories',150);

INSERT INTO Orders(OrderID,CustomerID,OrderDate)
VALUES
(1,1,'2023-01-15'),
(2,2,'2023-02-20'),
(3,3,'2023-03-25'),
(4,4,'2023-04-30');

INSERT INTO OrderDetails
(OrderDetailID,OrderID,ProductID,Quantity)
VALUES
(1,1,1,1),
(2,2,2,2),
(3,3,3,1),
(4,4,4,3);
