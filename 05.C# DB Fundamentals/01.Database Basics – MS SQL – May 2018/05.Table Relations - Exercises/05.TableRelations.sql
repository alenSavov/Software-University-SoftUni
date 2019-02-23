
/* ******************************************
01. One-To-One Relationship
*********************************************/
CREATE TABLE Passports(
       PassportID INT CONSTRAINT PK_PassportID PRIMARY KEY,
	   PassportNumber VARCHAR(50) NOT NULL
)
CREATE TABLE Persons(
       PersonID   INT CONSTRAINT PK_Person PRIMARY KEY,
	   FirstName  NVARCHAR(50) NOT NULL,
	   LastName   NVARCHAR(50) NOT NULL,
	   Salary     DECIMAL(15,2) NOT NULL,
	   PassportID INT CONSTRAINT FK_Persons_Passports
	      FOREIGN KEY REFERENCES Passports(PassportID)
)
/* ******************************************
02. One-To-Many Relationship
*********************************************/
CREATE TABLE Manufacturers(
       ManufacturerID INT CONSTRAINT PK_Manufacturers PRIMARY KEY,
	   [Name] NVARCHAR(50) NOT NULL,
	   EstablishedOn DATE NOT NULL    
)

CREATE TABLE Models(
       ModelID INT CONSTRAINT PK_ModelID PRIMARY KEY,
	   [Name]  NVARCHAR(50) NOT NULL,
	   ManufacturerID INT CONSTRAINT FK_Models_Manufactures
	      FOREIGN KEY REFERENCES Manufacturers(ManufacturerID) NOT NULL
)

INSERT INTO Manufacturers VALUES
(1, 'BMW','07/03/1916'),
(2, 'Tesla','01/01/2003'),
(3, 'Lada','01/05/1966')

INSERT INTO Models VALUES
(101,'X1'     ,1),
(102,'i6'	  ,1),
(103,'Model S',2),
(104,'Model X',2),
(105,'Model 3',2),
(106,'Nova'	  ,3)
/* ******************************************
03. Many-To-Many Relationship
*********************************************/

CREATE TABLE Students(
       StudentID INT CONSTRAINT PK_Students PRIMARY KEY,
	   [Name]    NVARCHAR(50) NOT NULL CONSTRAINT CHK_Students CHECK(LEN([Name]) > 2)
)

CREATE TABLE Exams(
       ExamID INT CONSTRAINT PK_Exams PRIMARY KEY,
	  [Name]    NVARCHAR(50) NOT NULL CONSTRAINT CHK_Exams CHECK(LEN([Name]) > 2)
)

CREATE TABLE StudentsExams(
       StudentID INT NOT NULL CONSTRAINT FK_StudentExams_Students
	     FOREIGN KEY REFERENCES Students(StudentID),
	   ExamID INT NOT NULL CONSTRAINT FK_StudentExams_Exams
		 FOREIGN KEY REFERENCES Exams(ExamID),
	   CONSTRAINT PK_StudentExams PRIMARY KEY (StudentID, ExamID)
)
/* ******************************************
04. Self-Referencing
*********************************************/
CREATE TABLE Teachers(
	   TeacherID INT CONSTRAINT PK_Teachers PRIMARY KEY,
	   [Name]    NVARCHAR(50) NOT NULL,
	   ManagerID INT CONSTRAINT FK_TeachersManager_TeacherTeacherID
	     REFERENCES Teachers(TeacherID)
)


INSERT INTO Teachers VALUES
(101,'John'	,NULL),
(102,'Maya'	,106),
(103,'Silvia',106),
(104,'Ted'	,105),
(105,'Mark'	,101),
(106,'Greta',101)

/* ******************************************
05. Online Store Database
*********************************************/
CREATE DATABASE OnlineStore
USE OnlineStore

CREATE TABLE Cities(
       CityID INT PRIMARY KEY,
	   [Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Customers(
       CustomerID INT PRIMARY KEY,
	   [Name] VARCHAR(50) NOT NULL 
	      CONSTRAINT CHK_Customers CHECK(LEN([Name]) > 2),
	   BirthDay DATE NOT NULL,
	   CityID INT CONSTRAINT FK_Customers_Cities
	      FOREIGN KEY REFERENCES Cities(CityID) NOT NULL
)

CREATE TABLE Orders(
       OrderID INT PRIMARY KEY,
	   CustomerID INT NOT NULL CONSTRAINT FK_Orders_Customers
	      REFERENCES Customers(CustomerID)
)

CREATE TABLE ItemTypes(
       ItemTypeID INT PRIMARY KEY,
	   [Name] VARCHAR(50) NOT NULL 
	     CONSTRAINT CHK_ItemTypes CHECK(LEN([Name]) > 2)
)

CREATE TABLE Items(
       ItemID INT PRIMARY KEY,
	   [Name] VARCHAR(50) NOT NULL
	     CONSTRAINT CHK_Items CHECK(LEN([Name]) > 2),
	   ItemTypeID INT CONSTRAINT FK_Items_ItemTypes
	     FOREIGN KEY REFERENCES ItemTypes(ItemTypeID) NOT NULL
)

CREATE TABLE OrderItems(
       OrderID INT CONSTRAINT FK_OrderItems_Orders
	     FOREIGN KEY REFERENCES Orders(OrderID),
	   ItemID INT CONSTRAINT FK_OrderItems_Items
	     FOREIGN KEY REFERENCES Items(ItemID),
	   CONSTRAINT PK_OrderItems PRIMARY KEY(OrderID, ItemID)
)
/* ******************************************
06. University Database
*********************************************/
CREATE DATABASE UniversityDatabase
USE UniversityDatabase

CREATE TABLE Majors(
	   MajorID INT PRIMARY KEY,
	   [Name] VARCHAR(50) NOT NULL CONSTRAINT CHK_Majors CHECK(LEN([Name]) > 2)
)

CREATE TABLE Subjects(
	   SubjectID INT PRIMARY KEY,
	   SubjectName VARCHAR(50) NOT NULL CONSTRAINT CHK_Subjects CHECK(LEN(SubjectName) > 2)
)

CREATE TABLE Students(
       StudentID INT PRIMARY KEY,
	   StudentNumber VARCHAR(50) NOT NULL,
	   StudentName   VARCHAR(50) NOT NULL CONSTRAINT CHK_Students CHECK(LEN(StudentName) > 2),
	   MajorID INT  NOT NULL CONSTRAINT FK_Students_Majors FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Payments(
       PaymentID INT PRIMARY KEY,
	   PaymentDate DATE NOT NULL,
	   PaymentAmount DECIMAL(15,4) NOT NULL,
	   StudentID INT NOT NULL CONSTRAINT FK_Payments_Students
	     FOREIGN KEY REFERENCES Students(StudentID)
)

CREATE TABLE Agenda(
       StudentID INT NOT NULL CONSTRAINT FK_Agenda_Students
	     REFERENCES Students(StudentID),
	   SubjectID INT NOT NULL CONSTRAINT FK_Agenda_Subjects
	     REFERENCES Subjects(SubjectID),
	   CONSTRAINT PK_Agenda PRIMARY KEY (StudentID, SubjectID)
)
/* ******************************************
09. *Peaks in Rila
*********************************************/
Use Geography

SELECT m.MountainRange, p.PeakName, p.Elevation
  FROM Mountains AS m
INNER join Peaks AS p ON p.MountainId = m.Id
WHERE MountainRange = 'Rila'
ORDER BY p.Elevation DESC

