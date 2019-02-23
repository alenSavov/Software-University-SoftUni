CREATE DATABASE RentACar
USE RentACar
GO
CREATE TABLE [Clients]
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Gender CHAR(1) CONSTRAINT CHK_gender CHECK(Gender='F' OR Gender='M'),
Birthdate DateTime,
CreditCard NVARCHAR(30) NOT NULL,
CardValidity DATETIME,
Email NVARCHAR(50) NOT NULL
)
CREATE TABLE [Towns]
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name NVARCHAR(50) NOT NULL
)
CREATE TABLE [Offices]
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name NVARCHAR(40),
ParkingPlaces INT,
TownId INT NOT NULL
CONSTRAINT FK_town FOREIGN KEY (TownId) REFERENCES Towns(Id)
)
CREATE TABLE [Models]
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Manufacturer NVARCHAR(50) NOT NULL,
Model NVARCHAR(50) NOT NULL,
ProductionYear DateTime,
Seats INT,
Class NVARCHAR(10),
Consumption DECIMAL (14,2)
)
CREATE TABLE [Vehicles]
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
ModelId INT NOT NULL
CONSTRAINT FK_model FOREIGN KEY(ModelId) REFERENCES Models(Id),
OfficeId INT NOT NULL
CONSTRAINT FK_office FOREIGN KEY (OfficeId) REFERENCES Offices(Id),
Mileage INT
)
CREATE TABLE [Orders]
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
ClientId INT NOT NULL
CONSTRAINT FK_client FOREIGN KEY (ClientId) REFERENCES Clients(Id),
TownId INT NOT NULL
CONSTRAINT FK_townpointer FOREIGN KEY (TownId) REFERENCES Towns(Id),
VehicleId INT NOT NULL
CONSTRAINT FK_vechicle FOREIGN KEY (VehicleId) REFERENCES Vehicles(Id),
CollectionDate DateTime NOT NULL,
CollectionOfficeId INT NOT NULL
CONSTRAINT FK_collectionOffice FOREIGN KEY (CollectionOfficeId) REFERENCES Offices(Id),
ReturnDate DateTime,
ReturnOfficeId INT  
CONSTRAINT FK_returnOffice FOREIGN KEY (ReturnOfficeId) REFERENCES Offices(Id),
Bill DECIMAL(14,2),
TotalMileage INT
)
GO
INSERT INTO [Models] VALUES
('Chevrolet','Astro','2005-07-27',4,'Economy',12.60),
('Toyota','Solara','2009-10-15',7,'Family',13.80),
('Volvo','S40','2010-10-12',3,'Average',11.30),
('Suzuki','Swift','2000-02-03',7,'Economy',16.20);
INSERT INTO [Orders] VALUES
(17,2,52,'2017-08-08',30,'2017-09-04',42,2360.00,7434),
(78,17,50,'2017-04-22',10,'2017-05-09',12,2326.00,7326),
(27,13,28,'2017-04-25',21,'2017-05-09',34,597.00,1880);
GO
UPDATE [Models]
SET Class = 'Luxury'
WHERE Consumption>20;
GO
DELETE FROM Orders
WHERE ReturnDate IS NULL
GO
SELECT Manufacturer,Model FROM [Models]
ORDER BY Manufacturer ASC,Id DESC
GO
SELECT  FirstName,LastName FROM [Clients]
WHERE DATEPART(YEAR,Birthdate) BETWEEN 1977 AND 1994
ORDER BY FirstName,LastName,Id
GO
SELECT t.Name AS 'TownName',o.Name AS [OfficeName],o.ParkingPlaces
FROM  [Offices] AS o
LEFT JOIN [Towns] AS t ON o.TownId=t.Id
WHERE o.ParkingPlaces>25
ORDER BY t.Name,o.Id
GO
 
SELECT m.Model, m.Seats, v.Mileage
FROM Vehicles AS v
INNER JOIN Models AS m ON m.Id = v.ModelId
WHERE v.Id != ALL (
        SELECT VehicleId FROM Orders WHERE ReturnDate IS NULL
)
ORDER BY v.Mileage ASC, m.Seats DESC, v.ModelId ASC, m.Model ASC
GO
SELECT t.Name AS 'TownName',COUNT(o.Name)AS 'OfficesNumber' FROM Offices AS o
INNER JOIN Towns AS t ON t.Id=o.TownId
GROUP BY t.Name
ORDER BY OfficesNumber DESC,TownName ASC
GO
SELECT m.Manufacturer,m.Model,COUNT(m.Model) AS 'TimesOrdered' FROM Models AS m
INNER JOIN Vehicles AS v ON v.ModelId=m.Id
LEFT JOIN Orders AS o ON v.Id=o.VehicleId
GROUP BY (m.Manufacturer)
ORDER BY TimesOrdered DESC,Manufacturer DESC,m.Model ASC
GO
SELECT m.Manufacturer,m.Model,COUNT(o.VehicleId) AS 'TimesOrdered'
 FROM Models AS m
LEFT JOIN Vehicles AS v ON v.ModelId=m.Id
FULL JOIN Orders AS o ON v.Id=o.VehicleId
GROUP BY m.Manufacturer,m.Model
ORDER BY TimesOrdered DESC,m.Manufacturer DESC,m.Model ASC
GO
--- zaebi taq kind person e wtf
GO
SELECT FirstName + ' ' + LastName AS Names, t.Class
  FROM Clients AS c
JOIN (SELECT ClientId, m.Class, DENSE_RANK() OVER(PARTITION BY o.ClientId ORDER BY COUNT(m.Class) DESC) AS RowClass
  FROM Orders AS o
JOIN Vehicles AS v ON o.VehicleId = v.Id
JOIN Models AS m ON v.ModelId = m.Id
GROUP BY ClientId, m.Class) AS t ON c.Id = t.ClientId
WHERE RowClass = 1
ORDER BY Names, t.Class, t.ClientId
GO
SELECT d.AgeGroup, SUM(d.Bill) AS Revenue,
            AVG(d.TotalMileage) AS AverageMileage
    FROM (
        SELECT c.BirthDate,
        CASE WHEN YEAR(c.BirthDate) BETWEEN 1970 AND 1979 THEN '70''s'
             WHEN YEAR(c.BirthDate) BETWEEN 1980 AND 1989 THEN '80''s'
             WHEN YEAR(c.BirthDate) BETWEEN 1990 AND 1999 THEN '90''s'
             ELSE 'Others'
        END AS AgeGroup,
             o.Bill, o.TotalMileage, o.Id
        FROM Clients AS c
        INNER JOIN Orders AS o ON o.ClientId = c.Id
        ) AS d
GROUP BY AgeGroup
ORDER BY AgeGroup
GO
SELECT DISTINCT m.Manufacturer,
       FORMAT(m.Consumption, '#.##.0000') AS [AverageConsumption]
  FROM Vehicles AS v
INNER JOIN Models AS m
        ON m.Id = v.ModelId
INNER JOIN (
                SELECT TOP(7)
                       m.Model
                  FROM Orders AS o
                INNER JOIN Vehicles AS v
                        ON v.Id = o.VehicleId
                INNER JOIN Models AS m
                        ON m.Id = v.ModelId
                GROUP BY m.Model
                ORDER BY COUNT(*) DESC
           ) AS MOM
        ON MOM.Model = m.Model
 WHERE m.Consumption BETWEEN 5 AND 15
GO
CREATE FUNCTION udf_CheckForVehicle (@townName NVARCHAR(50),@seatnumber INT)
RETURNS NVARCHAR(50)
AS
    BEGIN
    DECLARE @RESULT NVARCHAR(50)
     SET @RESULT =
       (SELECT TOP 1 CONCAT(o.Name,' - ',m.Seats)
        FROM   Offices AS o
        JOIN  Vehicles AS v ON o.Id= v.Id
        JOIN Models AS m ON m.Id=v.ModelId
        JOIN Towns AS t ON t.Id=o.TownId
        WHERE  t.Name=@townName AND m.Seats=@seatnumber
        ORDER BY o.Name ASC)
 
    IF(@RESULT IS NULL)
     SET @RESULT='NO SUCH VEHICLE FOUND'
RETURN @RESULT
END
GO
CREATE PROCEDURE usp_MoveVehicle @vehicleId INT, @officeId INT AS
 
    SET NOCOUNT ON;
 
    DECLARE @avaibleslots INT =(SELECT DISTINCT o.Parkingplaces-
    (SELECT COUNT(v.OfficeID)  FROM Vehicles AS v
    INNER JOIN offices AS o ON o.Id=v.OfficeID
    WHERE o.Id=@officeId
    GROUP BY v.OfficeID)
    FROM Vehicles AS v
    RIGHT JOIN offices AS o ON o.Id=v.OfficeID
    WHERE o.Id=@officeId);
 
    IF(@avaibleslots>0)
       UPDATE  Vehicles
       SET  officeId =@officeId
       WHERE Id=@vehicleId
    ELSE
    RAISERROR('Not enough room in this office!', 16,16)  
   
GO
    EXEC usp_MoveVehicle 7,32;
    SELECT OfficeId FROM Vehicles WHERE Id = 7
GO
SELECT dbo.udf_CheckForVehicle ('La Escondida', 9)
GO
CREATE TRIGGER increaseMileage ON [dbo].[Orders]
AFTER UPDATE
AS
    BEGIN
    SET nocount ON
    DECLARE @vehicle NVARCHAR(50),@newMileage INT;
    SELECT @vehicle= VehicleId FROM inserted
    SELECT @newMileage= TotalMileage FROM inserted
    UPDATE Vehicles
    SET Mileage+=@newMileage
    WHERE Id= @vehicle
    END
GO