--CREATE SALOON DATABASE
CREATE DATABASE Glamour_Grove
--USE THE DATABASE
USE Glamour_Grove
--SCHEMA TABLES

-- Customers Table
CREATE TABLE Customers (
    CustomerID VARCHAR(50) PRIMARY KEY,  -- Unique ID manually inserted from the application
    FullName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Address TEXT
)

-- Employees Table
CREATE TABLE Employees (
    EmployeeID VARCHAR(50) PRIMARY KEY,  
    FullName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE,
    RoleID VARCHAR(50),  
    Salary DECIMAL(10,2),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID) ON DELETE SET NULL
)

-- Roles Table 
CREATE TABLE Roles (
    RoleID VARCHAR(50) PRIMARY KEY,  
    RoleName VARCHAR(50) UNIQUE NOT NULL
)

-- Services Table
CREATE TABLE Service_Avail (
    ServiceID VARCHAR(50) PRIMARY KEY,  
    ServiceName VARCHAR(100) NOT NULL UNIQUE,
    Price DECIMAL(10,2) NOT NULL,
    Duration INT ,
    Description TEXT
)

-- Appointment Status Table 
CREATE TABLE AppointmentStatus (
    StatusID VARCHAR(50) PRIMARY KEY,  
    StatusName VARCHAR(20) UNIQUE NOT NULL
)

-- Appointments Table
CREATE TABLE Appointments (
    AppointmentID VARCHAR(50) PRIMARY KEY,  
    CustomerID VARCHAR(50),
    EmployeeID VARCHAR(50),
    ServiceID VARCHAR(50),
    AppointmentDateTime DATETIME NOT NULL,
    StatusID VARCHAR(50),  
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE SET NULL,
    FOREIGN KEY (ServiceID) REFERENCES Service_Avail(ServiceID) ON DELETE SET NULL,
    FOREIGN KEY (StatusID) REFERENCES AppointmentStatus(StatusID) ON DELETE SET NULL
)

-- User Details Table for Login/Signup
CREATE TABLE Users (
    UserID VARCHAR(50) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    User_Password VARCHAR(255) NOT NULL,
    User_Role VARCHAR(20) NOT NULL
)

-- Create Inventory Table
CREATE TABLE Inventory (
    InventoryID VARCHAR(50) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity >= 0),
    PricePerUnit DECIMAL(10,2) NOT NULL,
    Supplier VARCHAR(100)
)

--Data Insertion (Sample data)

-- Insert into Roles Table
INSERT INTO Roles (RoleID, RoleName) VALUES
('1', 'Hair Stylist'),
('2', 'Beautician'),
('3', 'Nail Technician'),
('4', 'Receptionist')

-- Insert into Employees Table
INSERT INTO Employees (EmployeeID, FullName, PhoneNumber, Email, RoleID, Salary) VALUES
('E001', 'Alice Johnson', '9876543210', 'alice@example.com', '1', 50000.00),
('E002', 'Bob Smith', '9876543211', 'bob@example.com', '2', 48000.00),
('E003', 'Charlie Brown', '9876543212', 'charlie@example.com', '3', 45000.00),
('E004', 'Daisy Adams', '9876543213', 'daisy@example.com', '4', 40000.00)

-- Insert into Customers Table
INSERT INTO Customers (CustomerID, FullName, PhoneNumber, Email, Address) VALUES
('C001', 'John Doe', '1234567890', 'john@example.com', '123 Street, City'),
('C002', 'Jane Smith', '1234567891', 'jane@example.com', '456 Avenue, City'),
('C003', 'Mike Johnson', '1234567892', 'mike@example.com', '789 Boulevard, City')

-- Insert into Service_Avail Table
INSERT INTO Service_Avail (ServiceID, ServiceName, Price, Duration, Description) VALUES
('S001', 'Haircut', 1500.00, 30, 'Basic Haircut Service'),
('S002', 'Facial', 2500.00, 45, 'Deep cleansing facial treatment'),
('S003', 'Manicure', 2000.00, 40, 'Full hand treatment with nail polish')

-- Insert into AppointmentStatus Table
INSERT INTO AppointmentStatus (StatusID, StatusName) VALUES
('ST1', 'Scheduled'),
('ST2', 'Completed'),
('ST3', 'Cancelled')

-- Insert into Appointments Table
INSERT INTO Appointments (AppointmentID, CustomerID, EmployeeID, ServiceID, AppointmentDateTime, StatusID) VALUES
('A001', 'C001', 'E001', 'S001', '2025-02-10 10:00:00', 'ST1'),
('A002', 'C002', 'E002', 'S002', '2025-02-11 11:30:00', 'ST2'),
('A003', 'C003', 'E003', 'S003', '2025-02-12 14:00:00', 'ST3')

-- Insert Sample Data into Users Table
INSERT INTO Users (UserID, Username, User_Password, User_Role) VALUES
('U001', 'employee1', 'emp123', 'Employee'),
('U002', 'customer1', 'cust123', 'Customer')

-- Insert Inventory Data
INSERT INTO Inventory (InventoryID, ProductName, Quantity, PricePerUnit, Supplier)
VALUES
    ('INV001', 'Shampoo', 50, 5.99, 'Beauty Supplies Co.'),
    ('INV002', 'Hair Color', 30, 7.49, 'Salon Essentials Ltd.'),
    ('INV003', 'Conditioner', 40, 6.29, 'Beauty Supplies Co.'),
    ('INV004', 'Hair Spray', 25, 8.99, 'Styling Needs Inc.'),
    ('INV005', 'Nail Polish', 60, 3.99, 'Nail Care Experts')

--Testing Queries

Select * from Customers

Select * from Service_Avail

Select * from Employees

Select * from Appointments where CustomerID='C001'

Select * from Users

select * from Inventory