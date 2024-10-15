--ASSIGNMENT 1

CREATE TABLE SalesTable(
	SaleID INT PRIMARY KEY IDENTITY(1,1),
	ProductID INT NOT NULL,
	ProductName VARCHAR(50) NOT NULL,
	QuantitySold INT NOT NULL,
	SaleAmount DECIMAL(10,2),
	SaleDate DATE
);

INSERT INTO SalesTable(ProductID, ProductName, QuantitySold, SaleAmount, SaleDate)
VALUES(101, 'Laptop', 5, 5000, '2024-09-01'),
	(102, 'Mouse', 10, 250, '2024-09-02'),
	(101, 'Laptop', 3, 3000, '2024-09-03'),
	(103, 'Keyboard', 8, 800, '2024-09-04'),
	(102, 'Mouse', 6, 150, '2024-09-05')

SELECT * FROM SalesTable

--Write a query to calculate the total sales amount for all products (SUM).
SELECT SUM(SaleAmount) AS SumOfSalesAmount FROM SalesTable

--Write a query to find the maximum quantity sold of any product (MAX).
SELECT MAX(QuantitySold) AS HighestQuantitySold FROM SalesTable

--SELECT MAX(TotalQuantity) AS MaxQuantity FROM(
--SELECT ProductID, SUM(QuantitySold) AS TotalQuantity FROM SalesTable GROUP BY ProductID
--) AS ProductSales


--Write a query to calculate the average sale amount per sale (AVG).
SELECT AVG(SaleAmount) AS AverageSale FROM SalesTable

--Write a query to find the minimum sale amount in the database (MIN).
SELECT MIN(SaleAmount) AS MinSaleAmount FROM SalesTable

--Write a query to calculate the total quantity sold of a specific product, say "Laptop"
--(SUM with WHERE clause).
SELECT ProductName, SUM(QuantitySold) AS QuantitySold
FROM SalesTable WHERE ProductName='Laptop' GROUP BY ProductName



------------------------------
--ASSIGNMENT 2

CREATE TABLE EmployeesTable(
	EmployeeID INT PRIMARY KEY IDENTITY(1,1),
	EmployeeName VARCHAR(50) NOT NULL,
	Department VARCHAR(50) NOT NULL,
	Salary DECIMAL(10,2),
	HireDate DATE
);

INSERT INTO EmployeesTable(EmployeeName, Department, Salary, HireDate)
VALUES('John Doe', 'IT', 5000, '2022-01-10'),
	('Jane Smith', 'HR', 6000, '2021-03-15'),
	('Bob Johnson', 'Finance', 5500, '2020-06-20'),
	('Alice Brown', 'IT', 6200, '2023-02-01'),
	('Charlie White', 'Marketing', 4800, '2023-03-10')

--Write a query to find the total salary expenditure for all employees (SUM).
SELECT SUM(Salary) AS TotalSalaryExpenditure FROM EmployeesTable

--Write a query to find the highest salary among all employees (MAX).
SELECT MAX(Salary) AS HighestSalary FROM EmployeesTable
SELECT TOP 1 EmployeeName, Salary FROM EmployeesTable ORDER BY Salary DESC

--Write a query to calculate the average salary across all employees (AVG).
SELECT AVG(SALARY) AS AverageSalary FROM EmployeesTable

--Write a query to find the minimum salary in the IT department (MIN with WHERE clause).
SELECT MIN(Salary) AS MinSalaryIT FROM EmployeesTable WHERE Department='IT'

--Write a query to find the total number of employees in each department (COUNT and GROUP BY).
SELECT Department, COUNT(EmployeeName) AS NoOfEmployees FROM EmployeesTable GROUP BY Department ORDER BY NoOfEmployees DESC



------------------------------
--ASSIGNMENT 3
CREATE TABLE Inventory(
	ProductID INT PRIMARY KEY IDENTITY(201,1),
	ProductName VARCHAR(50) NOT NULL,
	QuantityInStock INT NOT NULL,
	ReorderLevel INT NOT NULL,
	LastRestockDate DATE
);

INSERT INTO Inventory (ProductName, QuantityInStock, ReorderLevel, LastRestockDate)
VALUES('Monitor', 50, 10, '2024-08-25'),
    ('Printer', 30, 5, '2024-09-01'),
    ('Mouse', 100, 15, '2024-09-10'),
    ('Keyboard', 80, 20, '2024-09-15'),
    ('Laptop', 25, 5, '2024-09-20');

--Write a query to find the total quantity of products in stock (SUM).
SELECT SUM(QuantityInStock) FROM Inventory

--Write a query to find the product with the highest quantity in stock (MAX).
SELECT ProductName, QuantityInStock FROM Inventory WHERE QuantityInStock = (SELECT MAX(QuantityInStock) FROM Inventory)

--Write a query to find the average reorder level across all products (AVG).
SELECT AVG(ReorderLevel) AS AverageReorderLevel FROM Inventory

--Write a query to find the product with the lowest reorder level (MIN).
SELECT ProductName, ReorderLevel FROM Inventory WHERE ReorderLevel = (SELECT MIN(ReorderLevel) FROM Inventory)

--Write a query to find the total quantity in stock for products where the quantity is
--less than the reorder level (SUM with WHERE clause).
SELECT QuantityInStock FROM Inventory WHERE QuantityInStock<ReorderLevel



--------------------------------
--ASSIGNMENT 4

CREATE TABLE CustomerOrders(
	OrderID INT PRIMARY KEY IDENTITY(501,1),
	CustomerID VARCHAR(50) NOT NULL,
	OrderDate DATE NOT NULL,
	OrderAmount INT NOT NULL,
	QuantityOrdered INT NOT NULL
);

INSERT INTO CustomerOrders(CustomerID, OrderDate, OrderAmount, QuantityOrdered)
VALUES('C001', '2024-09-10', 1500, 3),
    ('C002', '2024-09-11', 2000, 5),
    ('C001', '2024-09-12', 1000, 2),
    ('C003', '2024-09-13', 2500, 4),
    ('C002', '2024-09-14', 3000, 6);

--Write a query to calculate the total order amount for all orders (SUM).
SELECT SUM(OrderAmount) AS SumOfOrders FROM CustomerOrders

--Write a query to find the average order amount for all customers (AVG).
SELECT AVG(OrderAmount) AS AverageOrderAmount FROM CustomerOrders

--Write a query to find the maximum order amount from a single order (MAX).
SELECT MAX(OrderAmount) AS MaxOrderAmount FROM CustomerOrders

--Write a query to find the total quantity ordered across all orders (SUM).
SELECT SUM(QuantityOrdered) AS AllOrders FROM CustomerOrders

--Write a query to find the minimum order amount in the database (MIN).
SELECT MIN(OrderAmount) AS MinOrderAmount FROM CustomerOrders



----------------------------------
--ASSIGNMENT 6

CREATE TABLE ProductRatings(
	RatingID INT PRIMARY KEY IDENTITY(1,1),
	ProductID VARCHAR(50) NOT NULL,
	CustomerID VARCHAR(50) NOT NULL,
	Rating INT NOT NULL,
	ReviewDate DATE NOT NULL
);

INSERT INTO ProductRatings(ProductID, CustomerID, Rating, ReviewDate)
VALUES('P001', 'C001', 4, '2024-09-01'),
    ('P002', 'C002', 5, '2024-09-02'),
    ('P001', 'C003', 3, '2024-09-03'),
    ('P003', 'C001', 2, '2024-09-04'),
    ('P002', 'C004', 4, '2024-09-05');

--Write a query to calculate the average rating for each product (AVG with GROUP BY).
SELECT ProductID, AVG(Rating) FROM ProductRatings GROUP BY ProductID

--Write a query to find the highest rating given to any product (MAX).
SELECT MAX(Rating) AS HighestRating FROM ProductRatings

--Write a query to find the lowest rating given to any product (MIN).
SELECT MIN(Rating) AS LowestRating FROM ProductRatings

--Write a query to find the total number of ratings for each product (COUNT and GROUP BY).
SELECT ProductID, COUNT(Rating) FROM ProductRatings GROUP BY ProductID

--Write a query to find the total number of products rated (COUNT with DISTINCT).
SELECT COUNT(DISTINCT ProductID) AS TotalProductsRated FROM ProductRatings






--------------------------
--OPERATORS
--------------------------

--ASSIGNMENT 1

INSERT INTO Employees (FirstName, LastName, Department, Salary)
VALUES
    ('John', 'Doe', 'IT', 60000),
    ('Jane', 'Smith', 'Finance', 70000),
    ('Robert', 'Johnson', 'HR', 55000),
    ('Emily', 'Davis', 'IT', 62000),
    ('Michael', 'Brown', 'Finance', 68000),
    ('Linda', 'Wilson', 'HR', 52000),
    ('David', 'Anderson', 'IT', 64000),
    ('Susan', 'Taylor', 'Finance', 73000);

--Retrieve the names of employees who work in either the 'HR', 'Finance', or 'IT' departments.
SELECT * FROM Employees WHERE Department IN ('HR','Finance','IT')


-------------------------------------
--ASSIGNMENT 2

--Retrieve the product names and prices of products that are priced between 100 and 500.

SELECT * FROM ProductsTable




