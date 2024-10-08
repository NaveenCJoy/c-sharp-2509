--ASSIGNMENT 6
--Create a tabled named Products and insert records in the table.
CREATE TABLE Products(
	ProductID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	ProductName varchar(50) NOT NULL,
	Category varchar(50),
	Price decimal(10,2),
	Stock int
);

INSERT INTO Products(ProductName, Category, Price, Stock)
VALUES('Laptop','Electronics',1000,50),
	('Mouse','Electronics',20,200),
	('Keyboard','Electronics',30,150),
	('Printer','Electronics',150,75)


--Select all columns from the Products table
SELECT * FROM Products


--Select products, sorted by their price in descending order.
SELECT * FROM Products
ORDER BY Price DESC


--Update the price of the "Mouse" to 25.
UPDATE Products
SET Price=25
WHERE ProductName='Mouse'


--Delete the product with ProductID 2 (Mouse).
DELETE FROM Products
WHERE ProductID=2 AND ProductName='Mouse'


--Select products sorted by ProductName in alphabetical order.
SELECT * FROM Products
ORDER BY ProductName ASC



---------------------

--ASSIGNMENT 7

--Create a tabled named Books with the below structure and insert records in the table.
CREATE TABLE Books(
	BookID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title varchar(50) NOT NULL,
	Author varchar(50) NOT NULL,
	PublishedYear int,
	AvailableCopies int
);

INSERT INTO Books(Title, Author, PublishedYear, AvailableCopies)
VALUES('The Great Gatsby','F. Scott Fitzgerald',1925, 3),
	('1984','George Orwell',1949,2),
	('To Kill a Mockingbird','Harper Lee',1960,5),
	('Brave New World','Aldous Huxley',1932,4)



--Update the available copies of "1984" to 5.
UPDATE Books
SET AvailableCopies=5
WHERE Title='1984'


--Delete the book with BookID 1 (The Great Gatsby).
DELETE FROM Books
WHERE BookId=1


--Write a query to Select books published after 1950.
SELECT * FROM Books
WHERE PublishedYear>1950



------------------
--ASSIGNMENT 8

--Create a Customers table containing details about customers.
CREATE TABLE Customers(
	CustomerID int PRIMARY KEY NOT NULL IDENTITY(201,1),
	CustomerName varchar(50),
	Email varchar(50),
	PhoneNumber varchar(50)
);


INSERT INTO Customers(CustomerName, Email, PhoneNumber)
VALUES('Alice Johnson','alice@example.com','555-1234'),
	('Bob Smith','bob@example.com','555-5678'),
	('Charlie Brown', 'charlie@example.com', '555-8765')


--Insert a new customer into the Customers table.
INSERT INTO Customers(CustomerName, Email, PhoneNumber)
VALUES('David Wilson','david@example.com','555-4321')

--Update the phone number of "Alice Johnson" to "555-9999".
UPDATE Customers
SET PhoneNumber='555-9999'
WHERE CustomerName='Alice Johnson'

--Delete the customer with CustomerID 202 (Bob Smith).
DELETE FROM Customers
WHERE CustomerID=202

SELECT * FROM Customers


------------------
--ASSIGNMENT 9

--Create an Orders table that contains information about customer orders.
CREATE TABLE OrdersTable(
	OrderID int PRIMARY KEY NOT NULL IDENTITY(301,1),
	CustomerID int NOT NULL,
	OrderDate varchar(50),
	TotalAmount decimal(10,2)
);

INSERT INTO OrdersTable(CustomerID, OrderDate, TotalAmount)
VALUES(201,'2024-09-01', 250.00),
	(202, '2024-09-02', 150.00),
	(203, '2024-09-03', 200.00)


--Insert a new order into the Orders table
INSERT INTO OrdersTable(CustomerID, OrderDate, TotalAmount)
VALUES(204,'2024-09-04', 300.00)

--Update the TotalAmount for OrderID 301 to 275.00.
UPDATE OrdersTable
SET TotalAmount=275
WHERE OrderID=301


--Delete the order with OrderID 302.
DELETE FROM OrdersTable
WHERE OrderID=302

--Select orders with a total amount greater than 200.
SELECT * FROM OrdersTable
WHERE TotalAmount>200

--Select only the OrderID and TotalAmount for all orders.
SELECT OrderID , TotalAmount FROM OrdersTable


-------------------
--ASSIGNMENT 10

--Create a Students table with a StudentID as the primary key and include the following columns: 
--FirstName, LastName, and Email. Insert three records into the table.
CREATE TABLE StudentsTable(
	StudentID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	FirstName varchar(50) NOT NULL,
	LastName varchar(50),
	Email varchar(50)
);

INSERT INTO StudentsTable(FirstName, LastName, Email)
VALUES('John', 'Doe', 'john.doe@example.com'),
	('Jane', 'Smith', 'jane.smith@example.com'),
	('Mike', 'Johnson', 'mike.johnson@example.com');

SELECT * FROM StudentsTable


--------------------------
--ASSIGNMENT 11

CREATE TABLE CoursesTable(
	CourseID int PRIMARY KEY IDENTITY(1,1),
	CourseName varchar(50) NOT NULL
);

INSERT INTO CoursesTable(CourseName)
VALUES('Python'),('Javascript'), ('C#'), ('.NET')

SELECT * FROM CoursesTable


CREATE TABLE Enrollments(
	EnrollmentID int PRIMARY KEY IDENTITY(1,1),
	StudentID int,
	CourseID int,
	FOREIGN KEY (StudentID) REFERENCES StudentsTable(StudentID),
	FOREIGN KEY (CourseID) REFERENCES CoursesTable(CourseID),
);

INSERT INTO Enrollments(StudentID, CourseID)
VALUES(1,1),(1,2),(2,2),(2,3),(3,1),(3,3)


SELECT * FROM Enrollments


------------------------
--ASSIGNMENT 12

--Create an OrderDetails table that contains OrderID, ProductID, and Quantity. Define a
--composite primary key using OrderID and ProductID.
CREATE TABLE OrderDetails(
	OrderID int,
	ProductID int,
	Quantity int,
	PRIMARY KEY(OrderID, ProductID)
);

SELECT * FROM OrderDetails


-----------------------------
--ASSIGNMENT 13
--Create a Users table with UserID as the primary key, and include Email and Username as
--candidate keys. Set the Email column as a unique key.
CREATE TABLE UsersTable(
	UserID int PRIMARY KEY IDENTITY(1,1),
	Email varchar(50) UNIQUE,
	Username varchar(50) UNIQUE,
);


------------------------------
--ASSIGNMENT 14
--Create a Products table with an AutoID as a surrogate key that automatically increments. Include
--ProductName and Price columns. CREATE TABLE ProductsTable(
	AutoID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);

INSERT INTO ProductsTable(ProductName,Price)
VALUES('Keyboard',800),('Mouse',250)
SELECT * FROM ProductsTable



------------------------------
--ASSIGNMENT 15
--Create a Employees table that uses SSN (Social Security Number) as a natural key. Include
--columns for FirstName, LastName, and Position. 
CREATE TABLE EmployeesTable (
    SSN CHAR(10) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Position VARCHAR(50)
);


------------------------------
--ASSIGNMENT 16
--Create a Customers table with a CustomerID as the primary key and a PhoneNumber column
--that must be unique. 
CREATE TABLE CustomersTable (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(15) UNIQUE NOT NULL
);






--VIEWS
--ASSIGNMENT 17

--Create a simple view named EmployeeView that displays the FirstName, LastName, and
--Department columns from the Employees table.CREATE VIEW CustomEmployeeView ASSELECT FirstName, LastName, DepartmentFROM Employees--Query the view to display the details.SELECT * FROM CustomEmployeeView------------------------------------ASSIGNMENT 18--Create a view named EditableEmployeeView that shows EmployeeID, FirstName,
--LastName, and SalaryCREATE VIEW EditableEmployeeView ASSELECT EmployeeID, FirstName, LastName, SalaryFROM Employees--Update the salary of an employee using the view. UPDATE EditableEmployeeViewSET Salary=65000WHERE FirstName='John' AND EmployeeID=7--Verify the updateSELECT * FROM EditableEmployeeView-----------------------------------ASSIGNMENT 19--Create a view named EmployeeSalaryBonusView that displays each employee’s
--FirstName, LastName, Salary, and a calculated column Bonus (10% of the salary). CREATE VIEW EmployeeSalaryBonusView ASSELECT FirstName, LastName, Salary, Salary+Salary*0.10 AS BonusFROM Employees--Query the viewSELECT * FROM EmployeeSalaryBonusView-------------------------------------ASSIGNMENT 20--Alter the EmployeeView from Assignment 1 to include a new column Salary.ALTER VIEW CustomEmployeeView ASSELECT FirstName, LastName, Department, SalaryFROM Employees--Verify the view with the updated column.SELECT * FROM CustomEmployeeView--------------------------------------ASSIGNMENT 21--Create a view named FilteredEmployeeView from employees table that displays
--EmployeeID,FirstName,LastName & Department. CREATE VIEW FilteredEmployeeView ASSELECT EmployeeID,FirstName,LastName, DepartmentFROM Employees--Use a query on the view to return employees in a specific department (e.g.,DepartmentID = 2). SELECT * FROM FilteredEmployeeView WHERE Department='HR'--------------------------------------ASSIGNMENT 22--Drop the EmployeeView that was created in the previous assignments. DROP VIEW CustomEmployeeView--Try to query the view again. SELECT * FROM CustomEmployeeView