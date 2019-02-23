
/* ******************************************
01. Records’ Count
*********************************************/
SELECT COUNT(*)
 FROM WizzardDeposits
/* ******************************************
02. Longest Magic Wand
*********************************************/
SELECT MAX(MagicWandSize)AS LongestMagicWand
  FROM WizzardDeposits
  /* ******************************************
03. Longest Magic Wand per Deposit Groups
*********************************************/
SELECT   DepositGroup, MAX(MagicWandSize)
  FROM   WizzardDeposits
GROUP BY DepositGroup
/* ******************************************
04. Smallest Deposit Group per Magic Wand Size
*********************************************/
SELECT TOP(2) DepositGroup
       FROM   WizzardDeposits	  
   GROUP BY DepositGroup    
   ORDER BY AVG(MagicWandSize)
/* ******************************************
05. Deposits Sum
*********************************************/
SELECT   DepositGroup, SUM(DepositAmount) AS [TotalSum]
  FROM   WizzardDeposits
GROUP BY DepositGroup
/* ******************************************
06. Deposits Sum for Ollivander Family
*********************************************/
SELECT    DepositGroup, SUM(DepositAmount) AS [TotalSum]
  FROM    WizzardDeposits
 WHERE    MagicWandCreator = 'Ollivander family'
 GROUP BY DepositGroup
 /* ******************************************
 07. Deposits Filter
*********************************************/
SELECT    DepositGroup, SUM(DepositAmount) AS [TotalSum]
  FROM    WizzardDeposits
 WHERE MagicWandCreator = 'Ollivander family'
 GROUP BY DepositGroup
 HAVING SUM(DepositAmount) < 150000
 ORDER BY TotalSum DESC
 /* ******************************************
 08. Deposit Charge
*********************************************/
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
  FROM WizzardDeposits 
  GROUP BY DepositGroup, MagicWandCreator
 /* ******************************************
 09. Age Groups
*********************************************/
SELECT e.AgeGropup, COUNT(e.AgeGropup) FROM(
SELECT 
  CASE  
    WHEN Age >= 0 AND Age <= 10 THEN '[0-10]'
    WHEN Age >= 11 AND Age <= 20 THEN '[11-20]'
    WHEN Age >= 21 AND Age <= 30 THEN '[21-30]'
    WHEN Age >= 31 AND Age <= 40 THEN '[31-40]'
    WHEN Age >= 41 AND Age <= 50 THEN '[41-50]'
    WHEN Age >= 51 AND Age <= 60 THEN '[51-60]'
    WHEN Age >= 61 THEN '[61+]'
  END AS [AgeGropup]
 FROM  WizzardDeposits AS [AgeGroup]
 ) AS e
 GROUP BY AgeGropup
  
 /* ******************************************
 10. First Letter
*********************************************/
SELECT LEFT(FirstName, 1)
  FROM  WizzardDeposits
  WHERE DepositGroup = 'Troll Chest'
  GROUP BY LEFT(FirstName, 1)
  ORDER BY LEFT(FirstName, 1)
 /* ******************************************
 11. Average Interest
*********************************************/
SELECT  DepositGroup, IsDepositExpired, AVG(DepositInterest)
  FROM  WizzardDeposits
  WHERE DepositStartDate > '01/01/1985'
  GROUP BY DepositGroup, IsDepositExpired
  ORDER BY DepositGroup DESC, IsDepositExpired
  /* ******************************************
  12. Rich Wizard, Poor Wizard
*********************************************/
SELECT SUM(e.Diff) AS [TotalSum] FROM(
SELECT DepositAmount - LEAD(DepositAMount) OVER (ORDER BY Id) AS Diff
  FROM WizzardDeposits
  ) AS e
/* ******************************************
13. Departments Total Salaries
*********************************************/
SELECT   DepartmentID, SUM(Salary)
  FROM   Employees
GROUP BY DepartmentID
ORDER BY DepartmentID
/* ******************************************
14. Employees Minimum Salaries
*********************************************/
SELECT DepartmentID, MIN(Salary) AS MinimumSalary
  FROM Employees
WHERE  DepartmentID IN (2,5,7) AND HireDate > '01/01/2000'
GROUP BY DepartmentID
/* ******************************************
15. Employees Average Salaries
*********************************************/
SELECT * INTO EmployeesAverageSalary
  FROM Employees
 WHERE Salary > 30000

 DELETE FROM EmployeesAverageSalary
 WHERE  ManagerID = 42

 UPDATE EmployeesAverageSalary 
    SET Salary += 5000
 WHERE  DepartmentID = 1
  
 SELECT  DepartmentID, AVG(Salary) AS [AverageSalary]
   FROM  EmployeesAverageSalary
GROUP BY DepartmentID
/* ******************************************
16. Employees Maximum Salaries
*********************************************/
SELECT   DepartmentID, MAX(Salary) AS MaxSalary
  FROM   Employees
GROUP BY DepartmentID
 HAVING  MAX(Salary) NOT BETWEEN 30000 AND 70000
/* ******************************************
17. Employees Count Salaries
*********************************************/
SELECT COUNT(Salary) AS [Count] 
  FROM Employees
  WHERE ManagerID IS NULL
  /* ******************************************
  18. 3rd Highest Salary
*********************************************/
SELECT DISTINCT DepartmentID, Salary FROM 
  (
         SELECT DepartmentID, Salary,
         DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC)  
         AS SalaryRank
         FROM Employees
  ) AS e
WHERE SalaryRank = 3
/* ******************************************
19. Salary Challenge
*********************************************/
SELECT TOP(10) FirstName, LastName, DepartmentID
  FROM Employees AS emp
  WHERE Salary > (SELECT AVG(Salary) FROM Employees WHERE DepartmentID = emp.DepartmentID)
  ORDER BY DepartmentID

