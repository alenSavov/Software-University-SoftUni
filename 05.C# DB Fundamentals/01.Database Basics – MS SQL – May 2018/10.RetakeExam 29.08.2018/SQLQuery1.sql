CREATE DATABASE Supermarket

USE Supermarket

GO

CREATE TABLE Categories(
	Id		 INT PRIMARY KEY IDENTITY,
	Name	 NVARCHAR(30) NOT NULL
)

CREATE TABLE Items(
	Id		     INT PRIMARY KEY IDENTITY,
	Name	     NVARCHAR(30) NOT NULL,
	Price	     DECIMAL(14,2) NOT NULL,
	CategoryId   INT CONSTRAINT FK_Items_Categories FOREIGN KEY REFERENCES Categories(Id) NOT NULL
)

CREATE TABLE Employees(
	Id			INT PRIMARY KEY IDENTITY,
	FirstName	NVARCHAR(50) NOT NULL,
	LastName	NVARCHAR(50) NOT NULL,
	Phone	    VARCHAR(12)  NOT NULL,
	Salary		DECIMAL(14,2) NOT NULL
)

CREATE TABLE Orders(
	Id		   INT PRIMARY KEY IDENTITY,
	DateTime   DATETIME NOT NULL,
	EmployeeId INT CONSTRAINT FK_Orders_Employees FOREIGN KEY REFERENCES Employees(Id) NOT NULL
)

CREATE TABLE OrderItems(
	OrderId	    INT NOT NULL,
	ItemId		INT NOT NULL,
	Quantity    INT NOT NULL CONSTRAINT CHK_OrderItems CHECK(Quantity >= 1)

	CONSTRAINT PK_OrderItems PRIMARY KEY(OrderId, ItemId)
	CONSTRAINT FK_OrderItems_Items FOREIGN KEY (ItemId) REFERENCES Items(Id),
	CONSTRAINT FK_OrderItemsFK_Orders FOREIGN KEY (OrderId) REFERENCES Orders(Id)
)

CREATE TABLE Shifts(
	Id			 INT NOT NULL IDENTITY,
	EmployeeId	 INT CONSTRAINT FK_Shifts_Employees FOREIGN KEY REFERENCES Employees(Id),
	CheckIn	     DATETIME NOT NULL,
	CheckOut	 DATETIME NOT NULL

	CONSTRAINT PK_Shifts PRIMARY KEY (Id, EmployeeId)
)


--2

INSERT INTO Employees (FirstName, LastName, Phone, Salary) VALUES
('Stoyan',	 'Petrov',	'888-785-8573',	500.25),
('Stamat',	 'Nikolov',	'789-613-1122',	999995.25),
('Evgeni',	 'Petkov',	'645-369-9517',	1234.51),
('Krasimir', 'Vidolov',	'321-471-9982',	50.25)

INSERT INTO Items (Name, Price, CategoryId) VALUES
('Tesla battery'  ,	   154.25,	8),
('Chess'		  ,	   30.25,	8),
('Juice'		  ,	   5.32,	1),
('Glasses'		  ,	     10,	8),
('Bottle of water',	   1,		1)


--3

UPDATE Items
     SET Price = Price  + (Price * 27) / 100  
WHERE  CategoryId IN (1,2,3)

--4

DELETE OrderItems
WHERE OrderId = 48

--5

SELECT e.Id, e.FirstName
  FROM Employees AS e
 WHERE e.Salary > 6500
 ORDER BY e.FirstName, e.Id

--6

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Phone AS [Phone Number]
  FROM Employees AS e
 WHERE e.Phone LIKE '3%'
ORDER BY e.FirstName, e.Phone

--7

SELECT e.FirstName, e.LastName, COUNT(o.Id) AS [Count]
  FROM Employees AS e
 JOIN Orders AS o ON o.EmployeeId = e.Id
GROUP BY e.FirstName,e.LastName
ORDER BY COUNT(o.Id) DESC, e.FirstName

--8 TODO

SELECT h.FirstName, h.LastName, h.[Work hours]
  FROM(
	   SELECT e.Id, e.FirstName, e.LastName, AVG(DATEPART(HOUR, s.CheckIn) + DATEPART(HOUR, s.CheckOut)) AS [Work hours]
	     FROM Employees AS e
	     JOIN Shifts AS s ON s.EmployeeId = e.Id
	    GROUP BY e.FirstName, e.LastName, E.Id
	   HAVING AVG(DATEPART(HOUR, s.CheckIn) + DATEPART(HOUR, s.CheckOut))  > 7
	 ) AS H
  ORDER BY [Work hours] DESC, h.Id

  --9

SELECT TOP(1) o.Id AS OrderId, SUM(i.Price * oi.Quantity) AS TotalPrice
  FROM OrderItems AS oi
  JOIN Orders AS o ON o.Id = oi.OrderId
  JOIN Items AS i ON i.Id = oi.ItemId
GROUP BY o.Id
ORDER BY TotalPrice DESC, o.Id
  
-- 10

SELECT TOP(10) o.Id, MAX(i.Price) AS ExpensivePrice, MIN(i.Price) AS CheapPrice
  FROM OrderItems AS oi
  JOIN Orders AS o ON o.Id = oi.OrderId
  JOIN Items AS i ON i.Id = oi.ItemId
  GROUP BY o.Id
  ORDER BY ExpensivePrice DESC, o.Id

  --11

  SELECT h.Id, h.FirstName, h.LastName
    FROM
	(
	  SELECT e.Id, e.FirstName, e.LastName
	    FROM Employees AS e
	    JOIN Orders AS o ON o.EmployeeId = e.Id
	    WHERE e.Id IS NOT NULL
		GROUP BY e.Id, e.FirstName, e.LastName
	 ) AS h
	    ORDER BY h.Id

-- 12
 -- cast(DATEDIFF(HOUR,cast(s.CheckIn as time),cast(s.CheckOut as time ))as float) AS [WorkingHours]
-- 13

SELECT TOP(10) h.FullName, h.[Total Price], h.Items
  FROM
  (
	SELECT e.FirstName + ' ' + e.LastName AS [FullName], 
		   SUM(i.Price * oi.Quantity) AS [Total Price],
		   SUM(oi.Quantity) AS [Items]
	FROM Employees AS e
	JOIN Orders AS o ON o.EmployeeId= e.Id
	JOIN OrderItems AS oi ON o.Id = oi.OrderId
	JOIN Items AS i ON i.Id = oi.ItemId	
	WHERE o.DateTime < '2018-06-15'
	GROUP BY e.FirstName, e.LastName
  ) AS h
ORDER BY h.[Total Price] DESC, h.Items DESC

--17
GO

SELECT h.ItemName, h.CategoryName, h.Count, h.TotalPrice
  FROM
  (
	SELECT i.Name AS [ItemName],
		   c.Name AS [CategoryName],
	       SUM(oi.Quantity) AS [Count],
		   SUM(i.Price * oi.Quantity) AS [TotalPrice]
	  FROM Items AS i
	  JOIN Categories AS c ON c.Id = i.CategoryId
	 JOIN OrderItems AS oi ON oi.ItemId = i.Id
      JOIN Orders AS o ON o.Id = oi.OrderId
	  WHERE oi.ItemId = i.Id
	  GROUP BY i.Name, c.Name
  ) AS h
ORDER BY h.TotalPrice DESC, H.Count


SELECT h.ItemName, h.CategoryName, h.Count, h.TotalPrice
  FROM
  (
	SELECT i.Name AS [ItemName],
		   c.Name AS [CategoryName],
	       SUM(oi.Quantity) AS [Count],
		   SUM(i.Price * oi.Quantity) AS [TotalPrice]
	  FROM OrderItems AS oi
	  JOIN Orders AS o ON o.Id = oi.OrderId
	LEFT   JOIN Items AS i ON i.Id = oi.ItemId
	  JOIN Categories AS c ON c.Id = i.CategoryId
	  WHERE oi.ItemId = i.Id
	  GROUP BY i.Name, c.Name
  ) AS h
ORDER BY h.TotalPrice DESC, H.Count


SELECT h.ItemName, h.CategoryName, h.Count, h.TotalPrice
  FROM
  (
	SELECT i.Name AS [ItemName],
		   c.Name AS [CategoryName],
	       SUM(oi.Quantity) AS [Count],
		   SUM(i.Price * oi.Quantity) AS [TotalPrice]
	  FROM Categories AS c
	  JOIN Items AS i ON i.CategoryId = c.Id
	 LEFT JOIN OrderItems AS oi ON oi.ItemId = i.Id
	  JOIN Orders AS o ON o.Id = oi.OrderId
	  WHERE oi.ItemId = i.Id
	  GROUP BY i.Name, c.Name
  ) AS h
ORDER BY h.TotalPrice DESC, H.Count

--20

CREATE TABLE DeletedOrders (
		OrderId INT NOT NULL,
		ItemId INT NOT NULL,
		ItemQuantity INT NOT NULL
)

CREATE TRIGGER tr_Delete ON Orders
INSTEAD OF DELETE 
AS
	BEGIN
	DECLARE @order INT =(SELECT Id
		FROM deleted)

		DELETE FROM Orders
		WHERE Id = @order

	END


