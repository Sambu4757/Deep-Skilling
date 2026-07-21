CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY(CustomerID)
    REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY(OrderID)
    REFERENCES Orders(OrderID),

    FOREIGN KEY(ProductID)
    REFERENCES Products(ProductID)
);

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);


CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,

    CustomerID INT,

    OrderDate DATE,

    FOREIGN KEY (CustomerID)
    REFERENCES Customers(CustomerID)
);


CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,

    OrderID INT,

    ProductID INT,

    Quantity INT,

    FOREIGN KEY (OrderID)
    REFERENCES Orders(OrderID),

    FOREIGN KEY (ProductID)
    REFERENCES Products(ProductID)
);