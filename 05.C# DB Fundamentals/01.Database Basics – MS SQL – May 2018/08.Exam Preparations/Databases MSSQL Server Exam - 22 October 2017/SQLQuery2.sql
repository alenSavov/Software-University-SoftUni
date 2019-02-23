CREATE DATABASE ReportService
GO
USE ReportService
GO

CREATE TABLE Users(
          Id        INT CONSTRAINT Id_Users PRIMARY KEY IDENTITY,
		  Username  NVARCHAR(30) NOT NULL UNIQUE,
		  [Password]  NVARCHAR(50) NOT NULL,
		  [Name]    NVARCHAR(50),
		  Gender    CHAR(1) CONSTRAINT CHK_Gender CHECK(Gender = 'M' OR Gender = 'F'),
		  BirthDate DATETIME,
		  Age       INT,
		  Email     NVARCHAR(50) NOT NULL
)

CREATE TABLE Departments(
             Id     INT CONSTRAINT Id_Department PRIMARY KEY IDENTITY,
			 [Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Employees(
		     Id           INT CONSTRAINT Id_Employees PRIMARY KEY IDENTITY,
			 FirstName    NVARCHAR(25),
			 LastName     NVARCHAR(25),
			 Gender       CHAR(1) CONSTRAINT CHK_Gender_Employees CHECK(Gender='M' OR Gender='F'),
			 BirthDate    DATETIME,
			 Age          INT,
			 DepartmentId INT NOT NULL CONSTRAINT FK_Employees_Departments FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Categories(
			 Id           INT CONSTRAINT Id_Categories PRIMARY KEY IDENTITY,
			 [Name]       VARCHAR(50) NOT NULL,
			 DepartmentId INT NOT NULL CONSTRAINT FK_Categories_Departmets REFERENCES Departments(Id)
)

CREATE TABLE [Status](
			 Id    INT CONSTRAINT Id_Status PRIMARY KEY IDENTITY,
			 Label VARCHAR(30) NOT NULL
)

CREATE TABLE Reports(
		     Id   INT CONSTRAINT Id_Reports PRIMARY KEY IDENTITY,
			 CategoryId INT NOT NULL CONSTRAINT FK_Reports_Categories FOREIGN KEY REFERENCES Categories(Id),
			 StatusId INT NOT NULL CONSTRAINT FK_Reports_Status REFERENCES [Status](Id),
			 OpenDate DATETIME NOT NULL,
			 CloseDate DATETIME,
			 Description VARCHAR(200),
			 UserId INT NOT NULL CONSTRAINT FK_Reports_Users FOREIGN KEY REFERENCES Users(Id),
			 EmployeeId INT CONSTRAINT FK_Reports_Employees FOREIGN KEY REFERENCES Employees(Id)
)

INSERT INTO Employees(FirstName,
					  LastName,
					  Gender,
					  BirthDate,
					  DepartmentId
)VALUES
('Marlo', 'O’Malley',	'M',	'9/21/1958','1'),
('Niki',	'Stanaghan',	'F','11/26/1969','4'),
('Ayrton',	'Senna',	'M',	'03/21/1960','9'),
('Ronnie',	'Peterson',	'M',	'02/14/1944','9'),
('Giovanna',	'Amati',	'F','07/20/1959','5')

INSERT INTO Reports(CategoryId,
					StatusId,
					OpenDate,
					CloseDate,
					Description,
					UserId,
					EmployeeId
)VALUES
('1',	'1',	'04/13/2017',    NULL,    'Stuck Road on Str.133' ,      '6', '2'),
('6',	'3',	'09/05/2015',	'12/06/2015',	'Charity trail running',       '3', '5'),
('14','2',	'09/07/2015',		NULL,   'Falling bricks on Str.58',    '5', '2'),
('4', '3',	'07/03/2017',	'07/06/2017',	'Cut off streetlight on Str.11','1','1')
/* ********************************************************
	03. Update 
***********************************************************/
GO
UPDATE  Reports
SET  StatusId = '2'
WHERE StatusId = '1' AND CategoryId = '4'
GO
DELETE FROM Reports
WHERE StatusId = '4'
/* ********************************************************
	05. Users by Age 
***********************************************************/
GO

SELECT Username, Age
  FROM Users
ORDER BY Age ASC, Username DESC
/* ********************************************************
06. Unassigned Reports 
***********************************************************/
GO

SELECT  r.Description, r.OpenDate
   FROM Reports AS r
   WHERE r.EmployeeId IS NULL
ORDER BY r.OpenDate ASC, r.Description ASC
/* ********************************************************
	07. Employees & Reports 
***********************************************************/
GO

SELECT   e.FirstName, e.LastName, r.Description, FORMAT(r.OpenDate, 'yyyy-MM-dd')
  FROM   Employees AS e
  JOIN   Reports AS r ON r.EmployeeId = e.Id
  WHERE  r.StatusId IS NOT NULL
ORDER BY e.Id ASC, r.OpenDate ASC, r.Id ASC
/* ********************************************************
	08. Most Reported Category 
***********************************************************/
GO

SELECT *
  FROM Categories AS c

 /* ********************************************************
	09. Employees in Category 
***********************************************************/
GO

SELECT c.Name, COUNT(e.Id)
  FROM Employees AS e
  JOIN Categories AS c ON c.DepartmentId = e.DepartmentId
 GROUP BY c.Name
/* ********************************************************
	10. Users per Employee 
***********************************************************/
 GO

 SELECT DISTINCT e.FirstName + ' ' + e.LastName AS [Name], COUNT(e.Id)
   FROM Employees AS e
   GROUP BY e.FirstName + ' ' + e.LastName
/* ********************************************************
	11. Emergency Patrol
***********************************************************/
 
 SELECT r.OpenDate, r.Description, u.Email AS [Reporter Email]
 FROM Reports AS r
 JOIN Categories AS c ON  c.Id = r.CategoryId
 JOIN Users AS u ON u.Id = r.UserId
 JOIN Departments AS d ON d.Id = c.DepartmentId
 WHERE r.CloseDate IS NULL   AND
 LEN(r.Description) > 20    AND
 r.Description LIKE '%str%' AND
 d.Name IN ('Infrastructure', 'Emergency', 'Roads Maintenance')
 ORDER BY r.OpenDate ASC, u.Email ASC, r.Id ASC
/* ********************************************************
	12. Birthday Report 
***********************************************************/
SELECT c.Name AS [CategoryName]
FROM Categories AS c 
JOIN Reports AS r ON r.Id = c.Id
JOIN Employees AS e ON e.Id = c.Id 
WHERE r.OpenDate = e.BirthDate
ORDER BY c.Name ASC

SELECT * FROM Reports
 /* ********************************************************
	13. Numbers Coincidence 
***********************************************************/
GO

SELECT DISTINCT u.Username
  FROM Users AS u
  JOIN Reports AS r ON r.UserId = u.Id
  JOIN Categories AS c ON c.Id = r.CategoryId
  WHERE Username LIKE '[0-9]%' OR Username LIKE '%[0-9]'
  AND c.Id

  

 

