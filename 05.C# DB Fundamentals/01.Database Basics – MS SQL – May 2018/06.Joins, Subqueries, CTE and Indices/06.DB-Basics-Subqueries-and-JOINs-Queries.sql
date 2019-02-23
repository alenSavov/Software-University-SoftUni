/* ******************************************
01. Employee Address
*********************************************/
SELECT TOP(5) EmployeeID, JobTitle, a.AddressID, a.AddressText
FROM Employees AS e
JOIN Addresses AS a
ON a.AddressID = e.AddressID
ORDER BY a.AddressID
/* ******************************************
02. Addresses with Towns
*********************************************/
SELECT TOP(50) e.FirstName, 
			   e.LastName,
   			   t.Name AS TownName,
   			   a.AddressText
    FROM Employees AS e
    JOIN Addresses AS a
      ON a.AddressID = e.AddressID
    JOIN Towns AS t
      ON t.TownID = a.TownID
ORDER BY FirstName, LastName
/* ******************************************
03. Sales Employees
*********************************************/
SELECT EmployeeID,
  	     FirstName,
  	     LastName,
  	     d.Name
    FROM Employees AS e
    JOIN Departments AS d 
      ON d.DepartmentID = e.DepartmentID
   WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID
/* ******************************************
04. Employee Departments
*********************************************/
SELECT TOP(5) e.EmployeeID,
   		      e.FirstName,
   			  e.Salary,
   			  d.Name
    FROM Employees AS e
    JOIN Departments AS d
      ON d.DepartmentID = e.DepartmentID
   WHERE e.Salary > 15000
ORDER BY d.DepartmentID
/* ******************************************
05. Employees Without Projects
*********************************************/
SELECT TOP(3) e.EmployeeID,
			  e.FirstName 
     FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep 
       ON ep.EmployeeID = e.EmployeeID
    WHERE ep.EmployeeID IS NULL
 ORDER BY e.EmployeeID
/* ******************************************
06. Employees Hired After
*********************************************/
SELECT   FirstName,
         LastName,
	     HireDate,
	     d.Name
    FROM Employees AS e
    JOIN Departments AS d
      ON d.DepartmentID = e.DepartmentID
   WHERE e.HireDate > 1/1/1999 
     AND d.Name = 'Sales' OR d.Name = 'Finance'
ORDER BY e.HireDate
/*******************************************
07. Employees With Project
*********************************************/
SELECT TOP(5) e.EmployeeID,
              e.FirstName,
	          p.Name AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p
ON p.ProjectID = ep.ProjectID
WHERE p.StartDate > 13/08/2002
AND p.EndDate IS NULL
ORDER BY e.EmployeeID
/*******************************************
08. Employee 24
*********************************************/
SELECT e.EmployeeID, e.FirstName,
 CASE  
   WHEN  p.StartDate >= '2005/01/01' THEN NULL
   ELSE  p.Name
 END    AS ProjectName
  FROM  Employees AS e
  JOIN  EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
  JOIN  Projects AS p ON p.ProjectID = ep.ProjectID
 WHERE  ep.EmployeeID = 24  
/* ******************************************
09. Employee Manager
*********************************************/
SELECT e.EmployeeID,
	   e.FirstName,
	   e.ManagerID,
	   ee.FirstName AS ManagerName
FROM Employees AS e
INNER JOIN Employees AS ee
ON e.ManagerID = ee.EmployeeID
WHERE ee.EmployeeID IN ('3', '7')
ORDER BY e.EmployeeID
/* ******************************************
10. Employees Summary
*********************************************/
SELECT TOP(50) e.EmployeeID,
       e.FirstName + ' ' + e.LastName AS EmployeeName,
      ee.FirstName + ' ' + ee.LastName AS ManagerName,
	   d.Name AS DepartmentName
      FROM Employees AS e
INNER JOIN Employees AS ee
ON e.ManagerID = ee.EmployeeID
INNER JOIN Departments AS d
        ON e.DepartmentID = d.DepartmentID
  ORDER BY e.EmployeeID
/* ******************************************
11. Min Average Salary
*********************************************/
  SELECT MIN(e.AverageSalary) AS MinAverageSalary
    FROM (
   SELECT AVG(Salary) AS AverageSalary
    FROM Employees
GROUP BY DepartmentID)  AS e
/* ******************************************
12. Highest Peaks in Bulgaria
*********************************************/
  SELECT mc.CountryCode,
	     m.MountainRange,
	     p.PeakName,
	     p.Elevation
    FROM MountainsCountries AS mc
    JOIN Mountains AS m
      ON m.Id = mc.MountainId
    JOIN Peaks AS p
      ON m.Id = p.MountainId
   WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY Elevation DESC
/* ******************************************
13. Count Mountain Ranges
*********************************************/
  SELECT mc.CountryCode,
	     COUNT(m.MountainRange) AS MountainRanges
    FROM MountainsCountries AS mc
    JOIN Mountains AS m
      ON m.Id = mc.MountainId
   WHERE mc.CountryCode IN ('BG','RU','US')
GROUP BY mc.CountryCode
/* ******************************************
14. Countries With or Without Rivers
*********************************************/
SELECT TOP (5) c.CountryName, ri.RiverName
      FROM Countries AS c
 LEFT JOIN CountriesRivers AS cr
        ON c.CountryCode = cr.CountryCode
 LEFT JOIN Rivers AS ri
        ON cr.RiverId = ri.Id
     WHERE c.ContinentCode IN 
		(
	    	SELECT DISTINCT co.ContinentCode 
		      FROM Continents AS co
		     WHERE co.ContinentName = 'Africa'
		)
ORDER BY c.CountryName
/* ******************************************
15. *Continents and Currencies
*********************************************/
WITH CTE_CountriesInfo (CountinentCode, CurrencyCode, CurrencyUsage) AS (
SELECT ContinentCode, CurrencyCode,  COUNT(CurrencyCode) AS CurrencyUsage
FROM Countries
GROUP BY ContinentCode, CurrencyCode
HAVING COUNT(CurrencyCode) > 1
)

SELECT e.CountinentCode, cci.CurrencyCode, e.MaxCurrency AS CurrencyUsage FROM (
SELECT CTE_CountriesInfo.CountinentCode, MAX(CurrencyUsage) AS MaxCurrency FROM CTE_CountriesInfo
GROUP BY CTE_CountriesInfo.CountinentCode) AS e
JOIN CTE_CountriesInfo AS cci ON cci.CountinentCode = e.CountinentCode AND 
cci.CurrencyUsage = e.MaxCurrency

/* ******************************************
16. Countries Without any Mountains
*********************************************/
SELECT COUNT(*) AS CountryCode
  FROM Countries AS c
  LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
  WHERE mc.CountryCode IS NULL

/* ******************************************
17. Highest Peak and Longest River by Country
*********************************************/
SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS HighestPeakElevation, MAX(ri.Length) AS LongestRiverLength
FROM Countries AS c

LEFT JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m
ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p
ON m.Id = p.MountainId
LEFT JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS ri
ON cr.RiverId = ri.Id
GROUP BY c.CountryName
ORDER BY MAX(p.Elevation) DESC, MAX(ri.Length) DESC, c.CountryName
/* ******************************************
18. *Highest Peak Name and Elevation by Country
*********************************************/
			
WITH CTE_PeaksInCountries (CountryName, PeakName, Elevation, MountainRange) AS (
SELECT   CountryName, p.PeakName, p.Elevation, mt.MountainRange
FROM     Countries AS c
LEFT JOIN     MountainsCountries AS m ON m.CountryCode = c.CountryCode
LEFT JOIN     Mountains AS mt ON mt.Id = m.MountainId
LEFT JOIN     Peaks AS p ON p.MountainId = mt.Id
GROUP BY c.CountryName, p.PeakName, p.Elevation, mt.MountainRange
	   )


SELECT TOP(5) e.CountryName,
	ISNULL(cci.PeakName,'(no highest peak)') AS [Highest Peak Name], 
	ISNULL(CCI.Elevation,0) AS [Highest Peak Elevation],
	ISNULL(cci.MountainRange, '(no mountain)') AS [Mountain]
  FROM (		 
		  SELECT CountryName, MAX(Elevation) AS MaxElevation
		    FROM CTE_PeaksInCountries
		GROUP BY CountryName) AS e
		   LEFT JOIN CTE_PeaksInCountries AS cci ON cci.CountryName = e.CountryName AND CCI.Elevation = E.MaxElevation
ORDER BY e.CountryName, cci.PeakName
	
