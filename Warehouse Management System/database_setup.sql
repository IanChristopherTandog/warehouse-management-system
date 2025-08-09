-- ========================================
-- Warehouse Management System - Database Setup
-- Creates database and tables for the application
-- Author: Ian Christopher Tandog
-- ========================================

-- Create database if it doesn't exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Warehouse')
BEGIN
    CREATE DATABASE Warehouse;
END
GO

-- Use the database
USE Warehouse;
GO

-- Create Inventory Table
CREATE TABLE Inventory
(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100),
    Quantity INT,
    Price INT,
    Description NVARCHAR(255),
    Category NVARCHAR(50)
);

-- Create Categories Table
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(150) NOT NULL
);

-- Create Orders Table
CREATE TABLE Orders (
    CustomerName VARCHAR(150) NOT NULL,
    ProductName VARCHAR(150) NOT NULL, 
    Category VARCHAR(150) NOT NULL,
    Price INT NOT NULL,
    OrdersQuantityNumericUpDown1 INT NOT NULL,
    TotalBox1 INT NOT NULL
);

-- Create Customers Table
CREATE TABLE Customers (
    CustomerName VARCHAR(150) NOT NULL PRIMARY KEY,
    ContactNo INT NOT NULL  
);

-- Optional: Insert Sample Data
INSERT INTO Categories (CategoryName) VALUES
('Electronics'),
('Furniture'),
('Clothing');

INSERT INTO Inventory (ProductName, Quantity, Price, Description, Category) VALUES
('Laptop', 10, 50000, 'Business laptop', 'Electronics'),
('Office Chair', 20, 2500, 'Ergonomic chair', 'Furniture'),
('T-Shirt', 50, 500, 'Cotton round-neck shirt', 'Clothing');

-- ========================================
-- End of Script
-- ========================================
