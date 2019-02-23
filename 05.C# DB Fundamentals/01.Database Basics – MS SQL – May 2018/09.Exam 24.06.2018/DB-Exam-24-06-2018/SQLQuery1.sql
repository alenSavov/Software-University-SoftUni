CREATE DATABASE TripService
GO
USE TripService
GO

--01. DDL 
CREATE TABLE Cities(
	         Id INT PRIMARY KEY IDENTITY,
	     [Name] NVARCHAR(20) NOT NULL,
	CountryCode CHAR(2) NOT NULL
)

CREATE TABLE Hotels(
	Id            INT PRIMARY KEY IDENTITY,
	[Name]        NVARCHAR(30) NOT NULL ,
	CityId        INT NOT NULL CONSTRAINT FK_Hotels_Cities FOREIGN KEY REFERENCES Cities(Id),
	EmployeeCount INT NOT NULL,
	BaseRate      DECIMAL(14,2)
)

CREATE TABLE Rooms(
	   Id   INT PRIMARY KEY IDENTITY,
	Price   DECIMAL(14,2) NOT NULL,
	[Type]  NVARCHAR(20) NOT NULL,
	Beds    INT NOT NULL,
	HotelId INT CONSTRAINT FK_Rooms_Hotels FOREIGN KEY REFERENCES Hotels(Id) NOT NULL
)

CREATE TABLE Trips(
	Id          INT PRIMARY KEY IDENTITY,
	RoomId      INT  CONSTRAINT FK_Trips_Rooms FOREIGN KEY REFERENCES Rooms(Id) NOT NULL,
	BookDate    DATE NOT NULL,
	ArrivalDate DATE NOT NULL,
	ReturnDate  DATE NOT NULL,
	CancelDate  DATE
)

CREATE TABLE Accounts(
	Id         INT PRIMARY KEY IDENTITY,
	FirstName  NVARCHAR(50)  NOT NULL,
	MiddleName NVARCHAR(20) ,
	LastName   NVARCHAR(50)  NOT NULL,
	CityId     INT CONSTRAINT FK_Accounts_Cities FOREIGN KEY REFERENCES Cities(Id) NOT NULL,
	BirthDate  DATE NOT NULL,
	Email      VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE AccountsTrips(
	AccountId INT NOT NULL,
	TripId INT NOT NULL,
	Luggage   INT CONSTRAINT CHK_AccountsTrips CHECK(Luggage >= 0) NOT NULL,
	CONSTRAINT FK_AccountsTrips_Accounts FOREIGN KEY (AccountId) REFERENCES Accounts(Id),
	CONSTRAINT FK_AccountsTrips_Trips FOREIGN KEY (TripId) REFERENCES Trips(Id),
    CONSTRAINT PK_AccountsTrips PRIMARY KEY(AccountId, TripId)
)

--02. Insert
GO

INSERT INTO Accounts(FirstName,
					 MiddleName,
					 LastName,
					 CityId,
					 BirthDate,
					 Email
) VALUES
('John',	    'Smith',	  'Smith',	   34,	'1975-07-21',	'j_smith@gmail.com'),
('Gosho',    	NULL,	      'Petrov',    11,	'1978-05-16',	'g_petrov@gmail.com'),
('Ivan',	    'Petrovich',  'Pavlov',	   59,	'1849-09-26',	'i_pavlov@softuni.bg'),
('Friedrich',	'Wilhelm',	  'Nietzsche',	2,	'1844-10-15',	'f_nietzsche@softuni.bg')


INSERT INTO Trips(RoomId,
			      BookDate,
				  ArrivalDate,
				  ReturnDate,
				  CancelDate
) VALUES
(101,	'2015-04-12',	'2015-04-14',	'2015-04-20',	'2015-02-02'),
(102,	'2015-07-07',	'2015-07-15',	'2015-07-22',	'2015-04-29'),
(103,	'2013-07-17',	'2013-07-23',	'2013-07-24',	NULL),
(104,	'2012-03-17',	'2012-03-31',	'2012-04-01',	'2012-01-10'),
(109,	'2017-08-07',	'2017-08-28',	'2017-08-29',	NULL)


--03. Update 
GO

UPDATE Rooms
SET Price = Price + (Price * 14) / 100
WHERE HotelId IN (5, 7, 9)

--04. Delete 
GO


DELETE FROM AccountsTrips
WHERE AccountId = 47

--05. Bulgarian Cities 
GO

SELECT c.Id, c.Name
  FROM Cities AS c
  WHERE c.CountryCode = 'BG'
  ORDER BY c.Name

--06. People Born After 1991 
GO

 select  rtrim(isnull(FirstName + ' ', '') +
            isnull(MiddleName + ' ', '') + 
            isnull(LastName + ' ', '')), YEAR(a.BirthDate) as [BirthYear]
  FROM Accounts AS a
 WHERE YEAR(a.BirthDate) > 1991 
  ORDER BY BirthYear DESC, a.FirstName 

--07. EEE-Mails 
GO

SELECT a.FirstName, a.LastName, FORMAT(a.BirthDate, 'MM-dd-yyyy'), c.[Name] AS [Hometown], a.Email
  FROM Accounts AS a
  JOIN Cities AS c ON c.Id = a.CityId
  WHERE a.Email LIKE 'e%'
  ORDER BY c.Name DESC


  --08. City Statistics 
GO

SELECT h.Name ,COUNT(h.Id)
  FROM
  (
	SELECT c.Name ,h.Id
	FROM Cities AS c
   LEFT	JOIN Hotels AS h ON h.CityId = c.Id
  ) AS h
  GROUP BY h.Name
  ORDER BY COUNT(h.Id) DESC, h.Name

--09. Expensive First Class Rooms 
GO

SELECT e.Id, e.Price, e.Name, e.CityName
 FROM
 (
	SELECT r.Id, r.Price, h.Name, c.Name AS [CityName]
	FROM Rooms AS r
	JOIN Hotels AS h ON h.Id = r.HotelId
	JOIN Cities AS c ON c.Id = h.CityId
	WHERE r.Type = 'First Class'
) AS e
ORDER BY e.Price DESC, e.Id 

--10. Longest and Shortest Trips 
GO

SELECT e.Id, e.FullName, MAX(e.Trip) AS [LongestTrip]
FROM
(
  SELECT a.Id, a.FirstName + ' ' + a.LastName AS [FullName], DATEDIFF(DAY,t.ArrivalDate,t.ReturnDate) AS [Trip]
  FROM Trips AS t
  JOIN AccountsTrips AS at ON at.AccountId = t.Id
  JOIN Accounts AS a ON a.Id = at.AccountId
  WHERE a.MiddleName IS NULL AND t.CancelDate IS NULL
) AS e
GROUP BY e.Id, e.FullName,e.Trip
ORDER BY e.Trip DESC, e.Id

SELECT * FROM AccountsTrips

--11. Metropolis 
GO
SELECT TOP(5) e.Id, e.Name, e.CountryCode, COUNT(e.AccountId) AS [Accounts]
  FROM
  (
     SELECT c.Id, c.Name, c.CountryCode, a.Id AS [AccountId]
     FROM Cities AS c
     JOIN Accounts AS a ON a.CityId = c.Id
  ) AS e
  GROUP BY e.Id, e.Name, e.CountryCode
  ORDER BY Accounts DESC

--13. Lucrative Destinations 
GO

SELECT TOP(10) c.Id, c.Name, SUM(h.BaseRate + r.Price) AS [Total Revenue], COUNT(at.AccountId) AS [Trips]
  FROM Cities AS c
  JOIN Hotels AS h ON h.CityId = c.Id
  JOIN Rooms AS r ON r.HotelId = h.Id
  JOIN Accounts AS a ON a.CityId = c.Id
  JOIN AccountsTrips AS at ON at.AccountId = a.Id
  JOIN Trips AS t ON t.Id = at.TripId
  WHERE YEAR(t.BookDate) = 2016
  GROUP BY c.Id, c.Name
  ORDER BY [Total Revenue] DESC , Trips DESC

  --12. Romantic Getaways 
  GO

  SELECT e.Id, e.Email, e.Name, COUNT(e.Trips)
    FROM 
	(
       SELECT a.Id, a.Email , c.Name,COUNT(at.TripId) AS [Trips]
       FROM  Accounts AS a
	  JOIN AccountsTrips AS at ON at.AccountId = a.Id
	  JOIN Cities AS c ON c.Id = a.CityId
	  JOIN Hotels AS h ON h.CityId = c.Id
	  WHERE at.TripId >= 1 AND c.Id = h.CityId
	  GROUP BY a.Id, a.Email, c.Name
	) as e
	GROUP BY e.Id, e.Email, e.Name, e.Trips
	ORDER BY e.Trips DESC, e.Id


	--20
	GO

CREATE TRIGGER tr_CancelTrip ON Trips
INSTEAD OF DELETE
AS
	BEGIN
	 DELETE FROM Trips

	END


