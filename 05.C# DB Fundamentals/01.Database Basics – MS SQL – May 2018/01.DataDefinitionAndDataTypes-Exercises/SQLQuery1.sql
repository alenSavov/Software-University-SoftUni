CREATE DATABASE Minions

USE Minions

CREATE TABLE Minions
 	(
 	Id INT NOT NULL PRIMARY KEY,
 	Name NVARCHAR(50) NOT NULL,
 	Age INT
 	)
 	 
 CREATE TABLE Towns
 	(
 	Id INT NOT NULL PRIMARY KEY,
 	Name NVARCHAR(50)
 	)

ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL;

INSERT INTO Towns(Id,
                  Name
                 )
VALUES
(
       1,
       'Sofia'
),
(
       2,
       'Plovdiv'
),
(
       3,
       'Varna'
);

INSERT INTO Minions(Id,
                    Name,
                    Age,
                    TownId
                   )
VALUES
(
       1,
       'Kevin',
       22,
       1
),
(
       2,
       'Bob',
       15,
       3
),
(
       3,
       'Steward',
       NULL,
       2
);

TRUNCATE Table Minions

Drop TABLE Minions;
Drop TABLE Towns;

CREATE TABLE People(
	Id INT UNIQUE  IDENTITY NOT NULL,
	Name      NVARCHAR(200) NOT NULL,
	Picture   VARBINARY(MAX),
	Height    NUMERIC(3,2),
	Weight    NUMERIC(5,2),
	Gender    CHAR(1) CHECK([Gender] IN('M', 'F'))NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

ALTER TABLE People
ADD PRIMARY KEY(Id);

ALTER TABLE People
ADD CONSTRAINT CH_PictureSize CHECK(DATALENGTH(Picture) <= 2 * 1024 * 1024);

INSERT INTO People(Name,
				   Gender,
				   Birthdate
				   )
VALUES
(
	'First Name',
	'M',
	'01-01-2000'
),
(
	'Secon Name',
	'F',
	'05-10-1999'
),
(
	'Third Name',
	'M',
	'07-08-2005'
),
(
	'Fourth Name',
	'F',
	'03-05-2007'
),
(
	'Fifth Name',
	'M',
	'08-08-2006'
);

/* ******************************************
	Problem 8. Create Table Users
*********************************************/

CREATE TABLE Users(
		     Id             BIGINT
			 UNIQUE IDENTITY NOT NULL,
			 Username       VARCHAR(30)
			 UNIQUE NOT NULL,
			 Password       VARCHAR(MAX),
			 ProfilePicture VARBINARY(MAX),
			 LastLoginTime  DATETIME2,
			 IsDeleted      BIT NOT NULL
							DEFAULT(0)    
);

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id);

ALTER TABLE Users
ADD CONSTRAINT CH_ProfilePicture CHECK(DATALENGTH(ProfilePicture) <= 900 * 1024);

INSERT INTO Users(Username,
                  Password
                 )
VALUES
(
       'First',
       'FpAsS'
),
(
       'Second',
       'SpAsS'
),
(
       'Third',
       'TpAsS'
),
(
       'Fourth',
       'FpAsS'
),
(
       'Fifth',
       'FfTpAsS'
);

/* ******************************************
	Problem 9. Change Primary Key
*********************************************/

ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_User PRIMARY KEY(Id, Username);

/* ******************************************
	Problem 10. Add Check Constraint
*********************************************/

ALTER TABLE Users
ADD CONSTRAINT CH_PasswordLength CHECK(LEN(Password) >= 5)

/* ******************************************
	Problem 11. Set Default Value of a Field
*********************************************/

ALTER TABLE Users ADD CONSTRAINT DF_LastLoginTime
 DEFAULT GETDATE() FOR LastLoginTime

 /* ******************************************
	Problem 12. Set Unique Field
*********************************************/

ALTER TABLE Users DROP CONSTRAINT PK_User

ALTER TABLE Users
ADD CONSTRAINT UC_Users UNIQUE(Username);

ALTER TABLE Users
ADD CONSTRAINT CHK_Users CHECK(LEN(Password) >= 3);

/* ******************************************
	Problem 13. Movies Database
*********************************************/

CREATE DATABASE Movies;

USE Movies;

CREATE TABLE Directors
(
             Id           INT NOT NULL PRIMARY KEY,
             DirectorName NVARCHAR(50) NOT NULL,
             Notes        NVARCHAR(MAX)
);

INSERT INTO Directors(Id,
                      DirectorName
                     )
VALUES
(
       1,
       'Director One'
),
(
       2,
       'Director Two'
),
(
       3,
       'Director Three'
),
(
       4,
       'Director Four'
),
(
       5,
       'Director Five'
);

CREATE TABLE Genres
(
             Id        INT NOT NULL PRIMARY KEY,
             GenreName NVARCHAR(50) NOT NULL,
             Notes     NVARCHAR(MAX)
);

INSERT INTO Genres(Id,
                   GenreName
                  )
VALUES
(
       1,
       'Genre One'
),
(
       2,
       'Genre Two'
),
(
       3,
       'Genre Three'
),
(
       4,
       'Genre Four'
),
(
       5,
       'Genre Five'
);

CREATE TABLE Categories
(
             Id           INT NOT NULL PRIMARY KEY,
             CategoryName NVARCHAR(50) NOT NULL,
             Notes        NVARCHAR(MAX)
);

INSERT INTO Categories(Id,
                       CategoryName
                      )
VALUES
(
       1,
       'Category One'
),
(
       2,
       'Category Two'
),
(
       3,
       'Category Three'
),
(
       4,
       'Category Four'
),
(
       5,
       'Category Five'
);

CREATE TABLE Movies
(
             Id            INT NOT NULL PRIMARY KEY,
             Title         NVARCHAR(255) NOT NULL,
             DirectorId    INT FOREIGN KEY REFERENCES Directors(Id),
             CopyrightYear INT,
             Length        NVARCHAR(50),
             GenreId       INT FOREIGN KEY REFERENCES Genres(Id),
             CategoryId    INT FOREIGN KEY REFERENCES Categories(Id),
             Rating        INT,
             Notes         NVARCHAR(MAX)
);

INSERT INTO Movies(Id,
                   Title,
                   DirectorId,
                   GenreId,
                   CategoryId
                  )
VALUES
(
       1,
       'Title One',
       2,
       3,
       4
),
(
       2,
       'Title Two',
       3,
       4,
       5
),
(
       3,
       'Title Three',
       1,
       2,
       3
),
(
       4,
       'Title Four',
       5,
       1,
       3
),
(
       5,
       'Title Five',
       3,
       5,
       2
);

/* ******************************************
	Problem 14. Car Rental Database
*********************************************/

CREATE DATABASE CarRental
GO

USE CarRental

CREATE TABLE Categories(
			 Id           INT NOT NULL PRIMARY KEY,
			 CategoryName NVARCHAR(50) NOT NULL,
			 DailyRate    DECIMAL(10, 2),
			 WeeklyRate   DECIMAL(10, 2),
			 MounthlyRate DECIMAL(10, 2),
			 WeekendRate  DECIMAL(10, 2)
);

ALTER TABLE Categories
ADD CONSTRAINT CK_AtLeastOneRate CHECK((DailyRate IS NOT NULL)
									   OR (WeeklyRate IS NOT NULL)
									   OR (MounthlyRate IS NOT NULL)
									   OR (WeekendRate IS NOT NULL));
INSERT INTO Categories(Id,
                       CategoryName,
                       DailyRate,
                       WeeklyRate,
                       MounthlyRate,
                       WeekendRate
                      )
VALUES
(
       1,
       'First Category',
       10,
       50,
       200,
       50
),
(
       2,
       'Second Category',
       20,
       90,
       330,
       100
),
(
       3,
       'Third Category',
       30,
       130,
       2700,
       155
);

CREATE TABLE Cars(
		     Id            INT PRIMARY KEY NOT NULL,
			 PlateNumber   VARCHAR(50) NOT NULL,
			 Manufacturer  VARCHAR(50) NOT NULL,
			 Model		   VARCHAR(50) NOT NULL,
			 CarYear       VARCHAR(50) NOT NULL,
			 CategoryId    INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
			 Doors		   INT NOT NULL,
			 Picture	   VARBINARY(MAX),
			 Condition     NVARCHAR(50),
			 Available     BIT DEFAULT 1
);

INSERT INTO Cars(Id,
				 PlateNumber,
				 Manufacturer,
				 Model,
				 CarYear,
				 CategoryId,
				 Doors,
				 Available
				 )
VALUES
(
       1,
       'CT7777CB',
       'BMW',
       '320',
       '2002',
       3,
       4,
       1
),
(
       2,
       'CT7557CB',
       'BMW',
       '535',
       '2009',
       3,
       4,
       1
),
(
       3,
       'CT7373CB',
       'BMW',
       '320',
       '1989',
       1,
       2,
       1
);

CREATE TABLE Employees(
			 Id			  INT PRIMARY KEY NOT NULL,
			 FirstName    NVARCHAR(50)  NOT NULL,
			 LastName	  NVARCHAR(50)  NOT NULL,
			 Title		  NVARCHAR(200) NOT NULL,
			 Notes        NVARCHAR(MAX)
);

INSERT INTO Employees(Id,
					  FirstName,
					  LastName,
					  Title
					  )
VALUES
(
	1,
	'Jon',
	'Makalister',
	'Title'
),
(
	2,
	'Bobi',
	'Jonson',
	'Title'
),
(
	3,
	'Ali',
	'Chaush',
	'Title'
);

CREATE TABLE Customers(
			 Id                   INT PRIMARY KEY NOT NULL,
			 DriverLicenceNumber  VARCHAR(50)     NOT NULL,
			 FullName		      NVARCHAR(200)   NOT NULL,
			 Address			  VARCHAR(200)    NOT NULL,
			 City                 VARCHAR(200)    NOT NULL,
			 ZIPCode			  INT             NOT NULL,
			 Notes                VARCHAR(MAX)
);

INSERT INTO Customers(Id,
					  DriverLicenceNumber,
					  FullName,
					  Address,
					  City,
					  ZIPCode
					  )
VALUES
(
       1,
	   '123',
	   'Joni Bravo',
	   'Amerika',
	   'New York',
	   4000
),
(
       2,
	   '1233',
	   'Jonna Brava',
	   'Hamerika',
	   'Stolupinovo',
	   10000
),
(
       3,
	   '1213',
	   'Kevin Jonsen',
	   'Amerika',
	   'Las Vegas',
	   40000
);

CREATE TABLE RentalOrders(
			 Id               INT PRIMARY KEY NOT NULL,
			 EmployeeId       INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
			 CustomerId       INT NOT NULL FOREIGN KEY REFERENCES Customers(Id),
			 CarId            INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
			 TankLevel        NUMERIC(5,2),
			 KilometrageStart INT,
			 KilometrageEnd   INT,
			 TotalKilometrage INT,
			 StartDate        DATE NOT NULL,
			 EndDate          DATE NOT NULL,
			 TotalDays        INT NOT NULL,
			 RateApplied      DECIMAL(10,2),
			 TaxRate          DECIMAL(10,2),
			 OrderStatus      NVARCHAR(50),
			 NOTES            NVARCHAR(MAX)
);

INSERT INTO RentalOrders(Id,
                         EmployeeId,
                         CustomerId,
                         CarId,
                         StartDate,
                         EndDate,
                         TotalDays
                        )
VALUES
(
       1,
       3,
       3,
       3,
       '01-01-2010',
       '01-02-2010',
       1
),
(
       2,
       1,
       1,
       1,
       '01-01-2010',
       '01-03-2010',
       2
),
(
       3,
       2,
       2,
       2,
       '01-01-2010',
       '01-04-2010',
       3
);

CREATE DATABASE Hotel 
GO

USE Hotel
			
CREATE TABLE Employees(
			 Id         INT PRIMARY KEY NOT NULL,
			 FirstName	NVARCHAR(50)    NOT NULL,
			 LastName   NVARCHAR(50)    NOT NULL,
			 Title      NVARCHAR(200)   NOT NULL,
			 Notes      NVARCHAR(MAX)
);
 
 INSERT INTO Employees(Id,
					   FirstName,
					   LastName,
					   Title
 )
 VALUES
 (
	1,
	'Gosho',
	'Ivanov',
	'English'
 ),
 (
	2,
	'Pesho',
	'Peshov',
	'Cars'
 ),
 (
	3,
	'Gosho',
	'Goshov',
	'Fish'
 );

 CREATE TABLE Customers(			              
			  AccountNumber   INT PRIMARY KEY NOT NULL,
			  FirstName       NVARCHAR(50)    NOT NULL,
			  LastName        NVARCHAR(50)    NOT NULL,
			  PhoneNumber     VARCHAR(50)     NOT NULL,
			  EmergencyName   NVARCHAR(50)    NOT NULL,
			  EmergencyNumber VARCHAR(50)     NOT NULL,
			  Notes           NVARCHAR(MAX)  
 );
 
 INSERT INTO Customers(AccountNumber,
					   FirstName,
					   LastName,
					   PhoneNumber,
					   EmergencyName,
					   EmergencyNumber					    
 )
 VALUES
 (
		'0001',
		'Pesho',
		'Peshov',
		'0888084474',
		'DDD',
		'112'
 ),
 (
		'00011',
		'Pesho',
		'Petrov',
		'08880844474',
		'DDD',
		'112'
 ),
 (
		'00201',
		'Pesho',
		'Goshov',
		'08880284474',
		'DDD',
		'112'
 );
 
 CREATE TABLE RoomStatus(
			  RoomStatus  NVARCHAR(50) PRIMARY KEY  NOT NULL,
			  Notes       NVARCHAR(50)
 ) 

 INSERT INTO RoomStatus(RoomStatus)
 VALUES
 (
	    'Free'
 ),
 (
        'In use'
 ),
 (
        'Reserved'
 )

 CREATE TABLE RoomTypes (
			  RoomType   NVARCHAR(50) PRIMARY KEY NOT NULL,
			  Notes       NVARCHAR(50)
 ) 
 INSERT INTO RoomTypes(RoomType)
 VALUES
 (
	    'Luxory'
 ),
 (
        'Casual'
 ),
 (
        'Misery'
 )

 CREATE TABLE BedTypes(
			  BedType   NVARCHAR(50) PRIMARY KEY NOT NULL,
			  Notes     NVARCHAR(MAX)
 ) 

 INSERT INTO BedTypes(BedType)
 VALUES
 (
	   'Small'
 ),
 (
	   'Big'
 ),
 (
	   'Double'
 )

 CREATE TABLE Rooms(
			  RoomNumber  NVARCHAR(50) PRIMARY KEY NOT NULL,
			  RoomType    NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES RoomTypes(RoomType),
			  BedType     NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES BedTypes(BedType),
			  Rate        NVARCHAR(50) NOT NULL,
			  RoomStatus  NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
			  Notes       NVARCHAR(MAX)
 )
 
 INSERT INTO Rooms(RoomNumber,
				   RoomType,
				   BedType,
				   Rate,
				   RoomStatus
 )
 VALUES 
 (
		'01',
		'Luxory',
		'Big',
		'Rate',
		'Free'
 ),
 (
		'02',
		'Luxory',
		'Big',
		'Rate',
		'Free'
 ),
 (
		'03',
		'Luxory',
		'Small',
		'Rate',
		'Free'
 )

 CREATE TABLE Payments(
			  Id		        INT NOT NULL PRIMARY KEY,
			  EmployeeId        INT NOT NULL FOREIGN KEY REFERENCES Employees(Id), 
			  PaymentDate       DATE NOT NULL,
			  AccountNumber     INT NOT NULL FOREIGN KEY REFERENCES Customers(AccountNumber),
			  FirstDateOccupied DATE NOT NULL,
			  LastDateOccupied  DATE NOT NULL,
			  TotalDays         INT NOT NULL,
              AmountCharged     DECIMAL(10, 2) NOT NULL,
              TaxRate           DECIMAL(10, 2) NOT NULL,
              TaxAmount         DECIMAL(10, 2) NOT NULL,
              PaymentTotal      DECIMAL(10, 2) NOT NULL,
              Notes             NVARCHAR(MAX)
 );
 
INSERT INTO Payments(Id,
                     EmployeeId,
                     PaymentDate,
                     AccountNumber,
                     FirstDateOccupied,
                     LastDateOccupied,
                     TotalDays,
                     AmountCharged,
                     TaxRate,
                     TaxAmount,
                     PaymentTotal
                    )
VALUES
(
       1,
       1,
       '10-05-2015',
       1,
       '10-05-2015',
       '10-10-2015',
       5,
       75,
       50,
       250,
       75
),
(
       2,
       3,
       '10-11-2015',
       1,
       '12-15-2015',
       '12-25-2015',
       10,
       100,
       50,
       500,
       100
),
(
       3,
       2,
       '12-23-2015',
       1,
       '12-23-2015',
       '12-24-2015',
       1,
       75,
       75,
       75,
       75
);

CREATE TABLE Occupancies
(
             Id            INT
             PRIMARY KEY NOT NULL,
             EmployeeId    INT NOT NULL,
             DateOccupied  DATE NOT NULL,
             AccountNumber INT NOT NULL,
             RoomNumber    INT NOT NULL,
             RateApplied   DECIMAL(10, 2),
             PhoneCharge   VARCHAR(50) NOT NULL,
             Notes         NVARCHAR(MAX)
);

INSERT INTO Occupancies(Id,
                        EmployeeId,
                        DateOccupied,
                        AccountNumber,
                        RoomNumber,
                        PhoneCharge
                       )
VALUES
(
       1,
       2,
       '08-24-2012',
       3,
       1,
       '088 88 888 888'
),
(
       2,
       3,
       '06-15-2015',
       2,
       3,
       '088 88 555 555'
),
(
       3,
       1,
       '05-12-1016',
       1,
       2,
       '088 88 555 333'
);


/* ******************************************
	Problem 16. Create SoftUni Database
*********************************************/

CREATE DATABASE SoftUni;
GO

USE SoftUni;

CREATE TABLE Towns
(
             Id   INT
             PRIMARY KEY IDENTITY NOT NULL,
             Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Addresses
(
             Id          INT
             PRIMARY KEY IDENTITY NOT NULL,
             AddressText NVARCHAR(100) NOT NULL,
             TownId      INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL
);

CREATE TABLE Departments
(
             Id     INT
             PRIMARY KEY IDENTITY NOT NULL,
             [Name] NVARCHAR(50) NOT NULL
);

CREATE TABLE Employees
(
             Id           INT
             PRIMARY KEY IDENTITY NOT NULL,
             FirstName    NVARCHAR(50) NOT NULL,
             MiddleName   NVARCHAR(50),
             LastName     NVARCHAR(50),
             JobTitle     NVARCHAR(100) NOT NULL,
             DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
             HireDate     DATE,
             Salary       DECIMAL(10, 2) NOT NULL,
             AddressId    INT FOREIGN KEY REFERENCES Addresses(Id)
);

/* ******************************************
	Problem 17. Backup Database
*********************************************/

BACKUP DATABASE SoftUni TO DISK = 'D:\softuni-backup.bak';

USE CarRental;

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni FROM DISK = 'D:\softuni-backup.bak';

/* ******************************************
	Problem 18.	Basic Insert
*********************************************/

USE SoftUni

INSERT INTO Towns(Name)
VALUES
(
       'Sofia'
),
(
       'Plovdiv'
),
(
       'Varna'
),
(
       'Burgas'
);

INSERT INTO Departments(Name)
VALUES
(
       'Engineering'
),
(
       'Sales'
),
(
       'Marketing'
),
(
       'Software Development'
),
(
       'Quality Assurance'
);

INSERT INTO Employees(FirstName,
                      MiddleName,
                      LastName,
                      JobTitle,
                      DepartmentId,
                      HireDate,
                      Salary
                     )
VALUES
(
       'Ivan',
       'Ivanov',
       'Ivanov',
       '.NET Developer',
       4,
       CONVERT(DATE, '02/03/2004', 103),
       3500.00
),
(
       'Petar',
       'Petrov',
       'Petrov',
       'Senior Engineer',
       1,
       CONVERT(DATE, '02/03/2004', 103),
       4000.00
),
(
       'Maria',
       'Petrova',
       'Ivanova',
       'Intern',
       5,
       CONVERT(DATE, '28/08/2016', 103),
       525.25
),
(
       'Georgi',
       'Teziev ',
       'Ivanov',
       'CEO',
       2,
       CONVERT(DATE, '09/12/2007', 103),
       3000.00
),
(
       'Peter',
       'Pan ',
       'Pan',
       'Intern',
       3,
       CONVERT(DATE, '28/08/2016', 103),
       599.88
);

/* ******************************************
	Problem 19. Basic Select All Fields
*********************************************/

SELECT *
FROM Towns;

SELECT *
FROM Departments;

SELECT *
FROM Employees;

/* ******************************************
	Problem 20. Basic Select All Fields and Order Them
*********************************************/

SELECT *
FROM Towns
ORDER BY Name ASC;

SELECT *
FROM Departments
ORDER BY Name ASC;

SELECT *
FROM Employees
ORDER BY Salary DESC;

/* ******************************************
	Problem 21.	Basic Select Some Fields
*********************************************/


SELECT [Name]
FROM Towns
ORDER BY [Name] ASC;

SELECT [Name]
FROM Departments
ORDER BY [Name] ASC;

SELECT [FirstName],
       [LastName],
       [JobTitle],
       [Salary]
FROM Employees
ORDER BY Salary DESC;

/* ******************************************
	Problem 22.	Increase Employees Salary
*********************************************/

UPDATE Employees
  SET
      Salary *= 1.10;

SELECT [Salary]
FROM Employees;

/* ******************************************
	Problem 23.	Decrease Tax Rate
*********************************************/

USE Hotel;

-- ALTER TABLE Payments
-- DROP CONSTRAINT [CK_TaxAmount];

UPDATE Payments
  SET
      TaxRate = TaxRate - (TaxRate * 0.03);

SELECT TaxRate
FROM Payments;

/* ******************************************
	Problem 24.	Delete All Records
*********************************************/

TRUNCATE TABLE Occupancies;

/* ----- DELETE Works but is slower than TRUNCATE -----
DELETE FROM Occupancies;
*/