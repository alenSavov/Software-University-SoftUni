--Task 17 - UDF GetReportsCount - DONE

CREATE FUNCTION udf_GetReportsCount(@employeeId INT, @statusId INT)
RETURNS INT
AS
BEGIN
    DECLARE @num INT= (SELECT COUNT(*)
                       FROM reports
                       WHERE Employeeid = @employeeId
                             AND Statusid = @statusId);
    RETURN @num;
END;

-- END Judge Submission

SELECT Id,
       Firstname,
       Lastname,
       dbo.udf_GetReportsCount(Id, 2)
FROM Employees;
GO

--Task 18 - Transaction - Assign Employee
CREATE PROC usp_AssignEmployeeToReport(@employeeId INT, @reportId INT)
AS
BEGIN
    BEGIN TRAN
		DECLARE @categoryId INT= (
								 SELECT Categoryid
								 FROM Reports
								 WHERE Id = @reportId);
		/*IF (@categoryId IS NULL)
		BEGIN;
		   THROW 50011,'Invalid report Id!', 1;
		   return;
		END*/

		DECLARE @employeeDepId INT= (
									SELECT Departmentid
									FROM Employees
									WHERE Id = @employeeId);
		/*IF (@employeeDepId IS NULL)
		BEGIN;
		   THROW 50012,'Invalid employee Id!', 1;
		   RETURN;
		END*/

		DECLARE @categoryDepId INT= (
									SELECT Departmentid
									FROM Categories
									WHERE Id = @categoryId);
		UPDATE Reports
		SET EmployeeId = @employeeId
		WHERE Id = @reportId

		IF @employeeId IS NOT NULL
		   AND @categoryDepId <> @employeeDepId
		BEGIN 
			ROLLBACK;
			THROW 50013,'Employee doesn''t belong to the appropriate department!', 1;
		END;   
    COMMIT; 
END;
--END Judge Submission

EXEC usp_AssignEmployeeToReport 17, 2;
SELECT EmployeeId FROM Reports WHERE id = 17

--Task 19 - Trigger - Close Reports

CREATE TRIGGER T_CloseReport ON Reports
AFTER UPDATE
AS
BEGIN
	UPDATE Reports
	SET StatusId = (SELECT Id FROM Status WHERE Label = 'completed')
	WHERE Id IN (SELECT Id FROM inserted
			     WHERE Id IN (SELECT Id FROM deleted
						      WHERE CloseDate IS NULL)
			           AND CloseDate IS NOT NULL)   
END;

--END Judge Submission 

UPDATE Reports
SET CloseDate = GETDATE()
WHERE EmployeeId = 5;
