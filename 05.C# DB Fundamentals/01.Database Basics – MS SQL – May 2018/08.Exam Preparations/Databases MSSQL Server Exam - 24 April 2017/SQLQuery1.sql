CREATE DATABASE WMS
GO
USE WMS
GO

--1. DDL
CREATE TABLE Clients(
	ClientId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Phone CHAR(12)
)

CREATE TABLE Mechanics(
	MechanicId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Address VARCHAR(255)
)

CREATE TABLE Models(
	ModelId INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) UNIQUE,
)

CREATE TABLE Jobs(
	JobId INT PRIMARY KEY IDENTITY(1,1),
	ModelId INT FOREIGN KEY REFERENCES Models(ModelId),
	Status VARCHAR(11) DEFAULT 'Pending' CHECK(Status = 'Pending' OR Status = 'In Progress' OR Status = 'Finished'),
	ClientId INT FOREIGN KEY REFERENCES Clients(ClientId),
	MechanicId INT FOREIGN KEY REFERENCES Mechanics(MechanicId),
	IssueDate DATE,
	FinishDate DATE
)

CREATE TABLE Orders(
	OrderId INT PRIMARY KEY IDENTITY(1,1),
	JobId INT FOREIGN KEY REFERENCES Jobs(JobId),
	IssueDate DATE NULL,
	Delivered BIT DEFAULT 'False'
)

CREATE TABLE Vendors(
	VendorId INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) UNIQUE
)

CREATE TABLE Parts(
	PartId INT PRIMARY KEY IDENTITY(1,1),
	SerialNumber VARCHAR(50) UNIQUE,
	Description VARCHAR(255),
	Price DECIMAL(8,2) CHECK(PRICE > 0),
	VendorId INT FOREIGN KEY REFERENCES Vendors(VendorId),
	StockQty INT DEFAULT 0 CHECK(StockQty >= 0)
)

CREATE TABLE OrderParts(
	OrderId INT,
	PartId INT,
	Quantity INT DEFAULT 1 CHECK(Quantity > 0),
	CONSTRAINT PK_OrderId_PartId PRIMARY KEY(OrderId, PartId),
	CONSTRAINT FK_OrderId_Orders FOREIGN KEY(OrderId) REFERENCES Orders(OrderId),
	CONSTRAINT FK_PartId_Parts FOREIGN KEY(PartId) REFERENCES Parts(PartId)
)

CREATE TABLE PartsNeeded(
	JobId INT,
	PartId INT,
	Quantity INT DEFAULT 1 CHECK(Quantity > 0),
	CONSTRAINT PK_JobId_PartId PRIMARY KEY(JobId, PartId),
	CONSTRAINT FK_JobId_Parts FOREIGN KEY(JobId) REFERENCES Jobs(JobId),
	CONSTRAINT FK_Parts FOREIGN KEY(PartId) REFERENCES Parts(PartId)
)


--2. Insert
INSERT INTO Clients (FirstName, LastName, Phone)
VALUES ('Teri', 'Ennaco', '570-889-5187'),
	   ('Merlyn', 'Lawler', '201-588-7810'),
	   ('Georgene', 'Montezuma', '925-615-5185'),
	   ('Jettie', 'Mconnell', '908-802-3564'),
	   ('Lemuel', 'Latzke', '631-748-6479'),
	   ('Melodie', 'Knipp', '805-690-1682'),
	   ('Candida', 'Corbley', '908-275-8357')

INSERT INTO Parts (SerialNumber, Description, Price, VendorId)
VALUES ('WP8182119', 'Door Boot Seal', '117.86', 2),
	   ('W10780048', 'Suspension Rod', '42.81', 1),
	   ('W10841140', 'Silicone Adhesive', '6.77', 4),
('WPY055980', 'High Temperature Adhesive', '13.94', 3)


--3. Update
UPDATE Jobs
SET MechanicId = 3
WHERE Status = 'Pending' AND MechanicId IS NULL

UPDATE Jobs
SET Status = 'In Progress'
WHERE MechanicId = 3 AND Status = 'Pending'


--4. Delete

DELETE FROM OrderParts
WHERE OrderId = 19
DELETE FROM Orders
WHERE OrderId = 19

--5. Clients By Name

SELECT FirstName, LastName, Phone FROM Clients
ORDER BY LastName, ClientId DESC

--6. Job Status
SELECT Status, IssueDate FROM Jobs
WHERE FinishDate IS NULL
ORDER BY IssueDate, JobId

--7. Mechanic Assignments
SELECT CONCAT(FirstName, ' ', LastName) AS Mechanic, j.Status, j.IssueDate FROM Mechanics AS m
JOIN Jobs AS j ON j.MechanicId = m.MechanicId
ORDER BY m.MechanicId, J.IssueDate, j.JobId

--8. Current Clients
SELECT CONCAT(FirstName, ' ', LastName) AS Client,
DATEDIFF(DAY, j.IssueDate, '20170424') AS 'Days Going',
j.Status 
FROM Clients AS c
JOIN Jobs AS j ON j.ClientId = c.ClientId
WHERE j.Status != 'Finished'
ORDER BY [Days Going] DESC, c.ClientId ASC

--9. Mechanic Performance
SELECT CONCAT(FirstName, ' ', LastName) AS Mechanic, a.AVGDays AS AverageDays
FROM Mechanics AS m
JOIN 
(SELECT m.MechanicId AS 'Mechanic', avg(datediff(day, j.IssueDate, j.FinishDate)) AS 'AVGDays' FROM Jobs AS j
 JOIN Mechanics AS m ON m.MechanicId = j.MechanicId
 WHERE STATUS = 'Finished'
GROUP BY m.MechanicId) AS a ON m.MechanicId = a.Mechanic 

--10. Hard Earners
SELECT TOP 3 
	CONCAT(FirstName, ' ', LastName) AS Mechanic ,
	COUNT(j.Status) AS Jobs
FROM Mechanics AS m
JOIN Jobs AS j ON J.MechanicId = M.MechanicId
WHERE j.Status != 'Finished'
GROUP BY CONCAT(FirstName, ' ', LastName)
HAVING (COUNT(j.Status) > 1)
ORDER BY Jobs DESC

--11. Available Mechanics

SELECT 
	CONCAT(m.FirstName, ' ', m.LastName) AS Available
FROM Mechanics AS m
JOIN
(SELECT * FROM Mechanics
WHERE MechanicId NOT IN (
SELECT MechanicId FROM Jobs
WHERE STATUS <> 'Finished' 
AND MechanicId IS NOT NULL)) AS s ON s.MechanicId = m.MechanicId

--12. Parts Cost
SELECT 
	ISNULL(SUM(p.Price * op.Quantity),0) AS [Parts Total] 
FROM Parts AS P
JOIN OrderParts AS op ON op.PartId = p.PartId
JOIN Orders AS o ON o.OrderId = op.OrderId
WHERE o.IssueDate > (DATEADD(WEEK, -3 , '2017/04/24'))

--13. Past Expenses
SELECT 
  j.JobId,
  ISNULL(SUM(p.Price * op.Quantity),0) AS [Total] 
  FROM Parts AS P
FULL JOIN OrderParts AS op ON p.PartId = op.PartId
FULL JOIN Orders AS o ON op.OrderId = o.OrderId
FULL JOIN Jobs AS j ON o.JobId = j.JobId
WHERE j.STATUS = 'Finished'
GROUP BY j.JobId
ORDER BY [Total] DESC, j.JobId

--14. Model Repair Time
SELECT m.ModelId, 
	   m.Name, 
	   CAST(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))AS VARCHAR(10)) + ' ' + 'days' AS [Average Service Time]
FROM Models AS m
JOIN Jobs AS j ON j.ModelId = m.ModelId
GROUP BY m.ModelId, m.Name
ORDER BY CAST(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))AS VARCHAR(10)) + ' ' + 'days'

--15. Faultiest Model
SELECT TOP 1 WITH TIES m.Name, COUNT(*) AS [Times Serviced],
(SELECT ISNULL(SUM(p.Price * op.Quantity),0) FROM Jobs AS j
JOIN Orders AS o ON O.JobId = j.JobId
JOIN OrderParts AS op ON op.OrderId = o.OrderId
JOIN Parts AS p ON p.[PartId] = op.PartId
WHERE j.ModelId = m.ModelId) AS [Parts Total]
 FROM Models AS m
JOIN Jobs AS j ON j.ModelId = m.ModelId
GROUP BY m.ModelId, m.Name
ORDER BY [Times Serviced] DESC

--15.2 vers
SELECT TOP (1) WITH TIES
         dd.Name AS Model,
        dd.[Times Serviced] AS [Times Serviced],
        t.[Parts Total] AS [Parts Total]
        FROM (
        SELECT TOP 100 j.ModelId AS ModelId,
        m.Name AS Name,
        COUNT(*) AS [Times Serviced]
        FROM Jobs AS j
        LEFT JOIN Models AS m ON j.ModelId = m.ModelId
        GROUP BY j.ModelId, m.Name
        ORDER BY [Times Serviced]) AS dd
        JOIN (SELECT TOP 100
              j.ModelId,
              m.Name AS Name,
              COUNT(*) AS [Times Serviced] ,
              ISNULL(SUM(p.Price * op.Quantity), 0) AS [Parts Total]
              FROM Jobs AS j
               FULL JOIN Models AS m ON j.ModelId = m.ModelId
              FULL JOIN Orders AS o ON o.JobId = j.JobId
              FULL JOIN OrderParts AS op ON op.OrderId = o.OrderId
              FULL JOIN Parts AS p ON p.PartId = op.PartId
              GROUP BY j.ModelId, m.Name
              ORDER BY [Times Serviced] DESC)
         AS t ON dd.Name = t.Name
         ORDER BY [Times Serviced] DESC

--16. Missing Parts
SELECT 
	p.PartId,
	p.[Description],
	SUM(pn.Quantity) AS [Required],
	AVG(p.StockQty) AS [In Stock],
	ISNULL(SUM(op.Quantity),0) AS [Ordered]
FROM Parts AS p
JOIN PartsNeeded AS pn ON pn.PartId = p.PartId
JOIN Jobs AS j ON j.JobId = pn.JobId
LEFT JOIN Orders AS o ON o.JobId = j.JobId
LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
WHERE j.Status <> 'Finished'
GROUP BY p.PartId, p.Description
HAVING SUM(pn.Quantity) > AVG(p.StockQty) + ISNULL(SUM(op.Quantity),0)
ORDER BY p.PartId

--17. Cost of Order
CREATE FUNCTION udf_GetCost (@JobId INT)
RETURNS DECIMAL(6,2)
AS
BEGIN
	DECLARE @TotalSum DECIMAL(6,2) = 
(SELECT ISNULL(SUM(p.Price * op.Quantity),0) FROM Parts AS p
JOIN OrderParts AS op ON op.PartId = p.PartId
JOIN Orders AS o ON o.OrderId = op.OrderId
JOIN Jobs AS j ON j.JobId = o.JobId
WHERE j.JobId = @JobId)

RETURN @TotalSum

END

--18. Place Order
CREATE PROC usp_PlaceOrder @JobId INT, @SerialNumber VARCHAR(50), @Quantity INT
AS
BEGIN
	IF(@Quantity <=0)
	BEGIN
		RAISERROR('Part quantity must be more than zero!', 16, 1)
		RETURN;
	END

	DECLARE @JobIdSelect INT = (SELECT JobId FROM Jobs WHERE JobId = @JobId)

	IF(@JobIdSelect IS NULL)
	BEGIN
		RAISERROR('Job not found!', 16, 1)
	END

	DECLARE @JobStatus VARCHAR(50) = (SELECT Status FROM Jobs WHERE JobId = @JobId)
	IF(@JobStatus = 'Finished')
	BEGIN
		RAISERROR('This job is not active!', 16, 1)
	END

	DECLARE @PartId INT = (SELECT PartId FROM Parts WHERE SerialNumber = @SerialNumber)
	IF(@PartId IS NULL)
	BEGIN
		RAISERROR('Part not found!', 16, 1)
		RETURN;
	END

	DECLARE @OrderId INT = (SELECT o.OrderId FROM Orders AS o
							JOIN OrderParts AS op ON op.OrderId = o.OrderId
							JOIN Parts AS p ON p.PartId = op.PartId
							WHERE JobId = @JobId AND p.PartId = @PartId AND IssueDate IS NULL)
	
	IF(@OrderId IS NULL)
	BEGIN
	INSERT INTO Orders(JobId, IssueDate) VALUES
	(@JobId, NULL)

	INSERT INTO OrderParts(OrderId, PartId, Quantity) VALUES
	(IDENT_CURRENT('Orders'), @PartId, @Quantity)
	END

	ELSE
	BEGIN
		DECLARE @PartExistanceOrder INT = (SELECT @@ROWCOUNT FROM OrderParts WHERE OrderId = @OrderId AND PartId = @PartId)

		IF(@PartExistanceOrder IS NULL)
		BEGIN
			INSERT INTO OrderParts(OrderId, PartId, Quantity) VALUES
			(@OrderId, @PartId, @Quantity)
		END

		ELSE
		BEGIN
			UPDATE OrderParts
			SET Quantity += @Quantity
			WHERE OrderId = @OrderId AND PartId = @PartId
		END
	END
END

--19. Detect Delivery
CREATE TRIGGER tr_OrderDeliver ON Orders AFTER UPDATE
AS
BEGIN

	DECLARE @OldStatus INT = (SELECT Delivered from deleted)
	DECLARE @NewStatus INT = (SELECT Delivered from inserted)

	IF(@OldStatus = 0 AND @NewStatus = 1)
	BEGIN
		UPDATE Parts
		SET StockQty += op.Quantity
		FROM Parts AS p
		JOIN OrderParts AS op ON op.PartId = p.PartId
		JOIN Orders AS o ON o.OrderId = op.OrderId
		JOIN inserted AS i ON i.OrderId = o.OrderId
		JOIN deleted AS d ON d.OrderId = i.OrderId
		
	END
END

--20. Vendor Preference
WITH CTE_Parts
AS
(
	SELECT m.MechanicId,
		   v.VendorId,
		   SUM(op.Quantity) AS VendorItems
	 FROM Mechanics AS m
	JOIN Jobs AS j ON j.MechanicId = m.MechanicId
	JOIN Orders AS o ON o.JobId = j.JobId
	JOIN OrderParts AS op ON op.OrderId = o.OrderId
	JOIN Parts AS p ON p.PartId = op.PartId
	JOIN Vendors AS v ON v.VendorId = P.VendorId
	GROUP BY m.MechanicId, v.VendorId
)

SELECT CONCAT(m.FirstName, ' ', m.LastName) AS [Mechanic],
	   v.Name AS [Vendor],
	   c.VendorItems AS [Parts],
	   CAST(CAST(CAST(VendorItems AS DECIMAL(6,2)) / (SELECT SUM(VendorItems) FROM CTE_Parts WHERE MechanicId = c.MechanicId) * 100 AS INT) AS VARCHAR(MAX)) + '%' AS Preference
	FROM CTE_Parts AS c
JOIN Mechanics AS m ON m.MechanicId = c.MechanicId
JOIN Vendors AS v ON v.VendorId = c.VendorId
ORDER BY Mechanic, Parts DESC, Vendor