--Task 5 - Users by Age

SELECT Username,
       Age
FROM Users
ORDER BY Age,
         Username DESC;

--Task 6 - Unassigned Reports

SELECT Description,
       Opendate
FROM Reports
WHERE Employeeid IS NULL
ORDER BY Opendate, 
		 Description;

--Task 7. Employees & Reports

SELECT E.Firstname,
       E.Lastname,
       R.Description,
       FORMAT(R.Opendate, 'yyyy-MM-dd') AS Opendate
FROM Employees AS E
     JOIN Reports AS R ON R.Employeeid = E.Id
ORDER BY E.Id,
         R.Opendate;

--Task 8 - Most reported Category

SELECT C.Name AS CategoryName,
       COUNT(*) AS ReportsNumber
FROM Categories AS C
     JOIN Reports AS R ON R.Categoryid = C.Id
GROUP BY C.Name
ORDER BY Reportsnumber DESC,
         Categoryname;

--Task 9. Employees in Category

SELECT C.Name,
       COUNT(E.Id) AS Numberemployees
FROM Categories AS C
     JOIN Departments AS D ON D.Id = C.Departmentid
     JOIN Employees AS E ON E.Departmentid = D.Id
GROUP BY C.Name;

--Task 10 - Birthday Reports

SELECT DISTINCT C.Name
FROM Categories C 
     JOIN Reports AS R ON R.CategoryId = C.Id
     JOIN Users AS U ON U.Id = R.Userid
WHERE DAY(R.Opendate) = DAY(U.Birthdate)
	 AND MONTH(R.Opendate) = MONTH(U.Birthdate)
ORDER BY C.Name;

-- Task 11 - Users per Employee

SELECT E.Firstname + ' ' + E.Lastname AS FullName,
       COUNT(DISTINCT R.Userid) AS UsersCount
FROM Employees AS E
     LEFT JOIN Reports AS R ON R.Employeeid = E.Id
GROUP BY E.Firstname + ' ' + E.Lastname
ORDER BY UsersCount DESC,
         FullName;

--Task 12 - Emergency Patrol

SELECT OpenDate, Description, u.email [Reporter Emial] 
FROM Reports r
	JOIN Users AS u on u.id = r.UserId
	JOIN Categories c on c.id = r.CategoryId
	JOIN Departments d on d.id = c.Departmentid 
WHERE Description LIKE '%str%' AND
	  LEN(Description) > 20 AND
	  CloseDate IS NULL AND
	  d.Id IN (1,4,5)
ORDER BY OpenDate, 
	     [Reporter Emial];

--Task 13 - Numbers Coincidence

SELECT DISTINCT Username 
FROM Users u
	JOIN Reports r on r.UserId = u.id
	JOIN Categories c ON c.id = r.CategoryId
WHERE (Username LIKE '[0-9]_%' AND CAST(c.id as varchar) = LEFT(username, 1)) OR
      (Username LIKE '%_[0-9]' AND CAST(c.id as varchar) = RIGHT(username, 1))
ORDER BY Username;

--Task 14 - Count open and closed reports per employee in the last month

SELECT E.Firstname+' '+E.Lastname AS FullName, 
	   ISNULL(CONVERT(varchar, CC.ReportSum), '0') + '/' +        
       ISNULL(CONVERT(varchar, OC.ReportSum), '0') AS [Stats]
FROM Employees AS E
JOIN (SELECT EmployeeId,  COUNT(1) AS ReportSum
	  FROM Reports R
	  WHERE  YEAR(OpenDate) = 2016
	  GROUP BY EmployeeId) AS OC ON OC.Employeeid = E.Id
LEFT JOIN (SELECT EmployeeId,  COUNT(1) AS ReportSum
	       FROM Reports R
	       WHERE  YEAR(CloseDate) = 2016
	       GROUP BY EmployeeId) AS CC ON CC.Employeeid = E.Id
ORDER BY FullName

--Task 15 - Average closing time

SELECT D.Name AS Departmentname,
       ISNULL(
	          CONVERT(
			          VARCHAR, AVG(DATEDIFF(DAY, R.Opendate, R.Closedate))
					 ), 'no info'
			 ) AS AverageTime
FROM Departments AS D
     JOIN Categories AS C ON C.DepartmentId = D.Id
     LEFT JOIN Reports AS R ON R.CategoryId = C.Id
GROUP BY D.Name
ORDER BY D.Name

--Task 16 - Favourite Categories

SELECT Department,
       Category,
       Percentage
FROM
    (SELECT D.Name AS Department,
		    C.Name AS Category,
		    CAST(
			     ROUND(
				       COUNT(1) OVER(PARTITION BY C.Id) * 100.00 / COUNT(1) OVER(PARTITION BY D.Id), 0
					  ) as int
				) AS Percentage
     FROM Categories AS C
		  JOIN Reports AS R ON R.Categoryid = C.Id
		  JOIN Departments AS D ON D.Id = C.Departmentid) AS Stats
GROUP BY Deprtment,
         Category,
         Percentage;
ORDER BY Deprtment,
         Category,
         Percentage;

--Task 20 - Bonus - Categories Revisiion

SELECT c.Name,
	  COUNT(r.Id) AS ReportsNumber,
	  CASE 
	      WHEN InProgressCount > WaitingCount THEN 'in progress'
		  WHEN InProgressCount < WaitingCount THEN 'waiting'
		  ELSE 'equal'
	  END AS MainStatus
FROM Reports AS r
    JOIN Categories AS c ON c.Id = r.CategoryId
    JOIN Status AS s ON s.Id = r.StatusId
    JOIN (SELECT r.CategoryId, 
		         SUM(CASE WHEN s.Label = 'in progress' THEN 1 ELSE 0 END) as InProgressCount,
		         SUM(CASE WHEN s.Label = 'waiting' THEN 1 ELSE 0 END) as WaitingCount
		  FROM Reports AS r
		  JOIN Status AS s on s.Id = r.StatusId
		  WHERE s.Label IN ('waiting','in progress')
		  GROUP BY r.CategoryId
		 ) AS sc ON sc.CategoryId = c.Id
WHERE s.Label IN ('waiting','in progress') 
GROUP BY C.Name,
	     CASE 
		     WHEN InProgressCount > WaitingCount THEN 'in progress'
		     WHEN InProgressCount < WaitingCount THEN 'waiting'
		     ELSE 'equal'
	     END
ORDER BY C.Name, 
		 ReportsNumber, 
		 MainStatus;