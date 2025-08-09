use Warehouse;

CREATE TABLE Inventory
(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100),
    Quantity INT,
    Price INT,
    Description NVARCHAR(255),
    Category NVARCHAR(50)
);



--ProductName,QuantityInventory,Price,Descr,Category

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(150) NOT NULL
);


CREATE TABLE Orders (
    OrderId INT	IDENTITY(1,1) PRIMARY KEY,
	CustomerName varchar(150) not null,
    ProductName varchar(150) not null, 
    Category varchar(150) not null,
    Price int not null,
    Quantity int not null,
    Total int not null
);

CREATE TABLE Customers (
	CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName varchar(150) not null,
    ContactNo int not null  
);


 

drop table Inventory
drop table Categories
drop table Orders
drop table Customers