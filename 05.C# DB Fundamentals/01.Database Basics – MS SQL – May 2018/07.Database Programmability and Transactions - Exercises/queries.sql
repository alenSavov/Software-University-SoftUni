/* ******************************************
03. Town Names Starting With
*********************************************/
GO

CREATE PROCEDURE usp_GetTownsStartingWith @startWith VARCHAR(30)
AS 
SELECT [Name]
  FROM Towns
  WHERE [Name] LIKE @startWith + '%'

EXEC usp_GetTownsStartingWith @startWith = 'b'
/* ******************************************
04. Employees from Town
*********************************************/
GO
CREATE PROCEDURE usp_GetEmployeesFromTown @townName VARCHAR(30)
AS
SELECT e.FirstName, e.LastName
  FROM Employees AS e
  JOIN Addresses AS a ON a.AddressID = e.AddressID
  JOIN Towns AS t ON t.TownID = a.TownID
  WHERE @townName = t.Name

EXEC usp_GetEmployeesFromTown @townName = 'Sofia'
/* ******************************************
05. Salary Level Function
*********************************************/
GO

CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS CHAR(7)
BEGIN
	IF(@salary < 30000) 
	BEGIN
		RETURN 'Low'
	END
	ELSE IF (@salary BETWEEN 30000 AND 50000)
	BEGIN
		RETURN 'Average'
	END
	
	RETURN 'High'
END

SELECT dbo.ufn_GetSalaryLevel(40000)
/* ******************************************
06. Employees by Salary Level
*********************************************/
GO
CREATE PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel CHAR(7)
AS
BEGIN 
SELECT FirstName, LastName
  FROM Employees
  WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
END

EXEC usp_EmployeesBySalaryLevel @salaryLevel = 'High'
/* ******************************************
07. Define Function
*********************************************/
GO

CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT 
BEGIN
DECLARE @index INT = 1
DECLARE @currentChar CHAR(1)
DECLARE @isComprised INT


WHILE (@index <= LEN(@word))
BEGIN

	SET @currentChar = SUBSTRING(@word, @index, 1)
	SET @isComprised = CHARINDEX(@currentChar, @setOfLetters)
	SET @index += 1

	IF (@isComprised = 0)
	BEGIN
		RETURN 0
	END
END
RETURN 1 
END

SELECT dbo.ufn_IsWordComprised('oistmiahf', 'Sofia')
/*******************************************
08. Delete Employees and Departments
*********************************************/
CREATE PROCEDURE usp_DeleteEmployeesFromDepartment (@departmentId INT)
RETURNS INT
BEGIN

SELECT EmployeeID
  FROM Employees AS e
  JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
  DELETE FROM Departments
END

/* ******************************************
09. Find Full Name
*********************************************/
GO

CREATE PROCEDURE usp_GetHoldersFullName 
AS
BEGIN

SELECT a.FirstName + ' ' + a.LastName AS [Full Name]
  FROM AccountHolders AS a

END

EXEC usp_GetHoldersFullName
/* ******************************************
10. People with Balance Higher Than
*********************************************/
GO

CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan (@number DECIMAL(14,2))
AS
BEGIN

SELECT e.FirstName, e.LastName
  FROM 
   (
	  SELECT ah.FirstName, ah.LastName
	    FROM AccountHolders AS ah
	    JOIN Accounts AS a ON a.AccountHolderId = ah.Id
	GROUP BY ah.FirstName, ah.LastName
      HAVING SUM(a.Balance) > @number
   ) AS e
END

EXEC usp_GetHoldersWithBalanceHigherThan @number = 0.2
/* ******************************************
11. Future Value Function
*********************************************/
GO
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(14,4), @yearlyRate FLOAT,@numberOfYears INT)
RETURNS DECIMAL(14,4)
BEGIN

DECLARE @fv DECIMAL(14,4) 

SET @fv = @sum * (POWER((1 + @yearlyRate),@numberOfYears))
RETURN @fv
END

SELECT dbo.ufn_CalculateFutureValue (1000, 0.1, 5)
 /* ********************************************************
	12. Calculating Interest 
***********************************************************/
GO

CREATE PROCEDURE usp_CalculateFutureValueForAccount (@AccountId INT, @interest DECIMAL(14,2))
AS
BEGIN
SELECT TOP(1) a.Id AS [Account Id],
       ah.FirstName AS [First Name],
       ah.LastName AS [LastName],
	   a.Balance AS [Current Balance],
	   dbo.ufn_CalculateFutureValue (a.Balance, @interest, 5) AS [Balance in 5 years]	   
  FROM Accounts AS a
  JOIN AccountHolders AS ah ON ah.Id = a.AccountHolderId
  WHERE a.AccountHolderId = @AccountId
END

--EXEC dbo.usp_CalculateFutureValueForAccount 1, 0.1
EXEC dbo.usp_CalculateFutureValueForAccount @AccountId = 1, @interest = '0.1'
 /* ********************************************************
	13. *Cash in User Games Odd Rows 
***********************************************************/
GO

CREATE FUNCTION ufn_CashInUsersGames (@gameName VARCHAR(50))
RETURNS TABLE
AS
RETURN
(
  SELECT SUM(e.Cash) AS [SumCash]
	FROM (
	 SELECT g.Id, ug.Cash, ROW_NUMBER() OVER (ORDER BY ug.Cash DESC) AS [RowNumber]
	  FROM Games AS g
	  JOIN UsersGames AS ug ON ug.GameId = g.Id
	  WHERE g.Name = @gameName) AS e
  WHERE e.RowNumber % 2 = 1  
)

SELECT * FROM dbo.ufn_CashInUsersGames('Lily Stargazer')
 /* ********************************************************
	Section II. Triggers and Transactions
***********************************************************/
/* ********************************************************
	14. Create Table Logs 
***********************************************************/
GO

CREATE TABLE Logs
    (
       LogId     INT IDENTITY PRIMARY KEY,
       AccountId INT,
       OldSum    DECIMAL (15,2),
       NEwSum    DECIMAL (15,2)
    )

CREATE TRIGGER tr_Accounts ON Accounts AFTER UPDATE
AS

BEGIN
   DECLARE @accountId INT = (SELECT Id FROM inserted)
   DECLARE @oldBalance DECIMAL(15,2) = (SELECT Balance FROM deleted)
   DECLARE @newBalance DECIMAL(15,2) = (SELECT Balance FROM inserted) 
   
   IF(@newBalance <> @oldBalance)
     INSERT INTO Logs VALUES (@accountId, @oldBalance, @newBalance)
END

UPDATE Accounts SET Balance = 100 WHERE Id = 1
SELECT * FROM Logs
/* ********************************************************
15. Create Table Emails 
***********************************************************/
CREATE TABLE NotificationEmails (
	   Id INT IDENTITY PRIMARY KEY,
	   Recipient INT,
	   Subject VARCHAR(200),
	   Body VARCHAR(200)
)

CREATE TRIGGER tr_tr_LogsNotificationEmails ON Logs FOR INSERT
AS
BEGIN
 
 DECLARE @recipient INT = (SELECT AccountId FROM inserted);
 DECLARE @oldBalance DECIMAL(14,2) = (SELECT OldSum FROM inserted);
 DECLARE @newBalance DECIMAL(14,2) = (SELECT NewSum FROM inserted);
 DECLARE @subject varchar(200) = CONCAT('Balance change for account: ', @recipient);
 DECLARE @body varchar(200) = CONCAT('On ', GETDATE(), 'your balance was changed from ',@oldBalance, ' to ', @newBalance, '.');

 INSERT INTO NotificationEmails (Recipient, Subject, Body)
 VALUES (@recipient, @subject, @body)
END


 /* ********************************************************
	16. Deposit Money 
***********************************************************/
CREATE PROCEDURE usp_DepositMoney @accountId INT, @moneyAmount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE Accounts
	   SET Balance = Balance + @moneyAmount
	 WHERE Id = @accountId

	IF (@@ROWCOUNT <> 1)
	BEGIN
		RAISERROR('Invalid account!', 16, 1);
		ROLLBACK;
		RETURN
	END
	COMMIT
END
