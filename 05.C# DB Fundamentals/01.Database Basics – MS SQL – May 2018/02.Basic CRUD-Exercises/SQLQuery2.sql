/* ******************************************
10. Countries Holding 'A'
*********************************************/
SELECT CountryName,
	   IsoCode AS [ISO Code]
  FROM Countries
 WHERE CountryName LIKE '%a%a%a%'
 ORDER BY IsoCode;
 /* ******************************************
 --11. Mix of Peak and River Names
*********************************************/
SELECT Peaks.PeakName,
       Rivers.RiverName,
       LOWER(CONCAT(LEFT(Peaks.PeakName, LEN(Peaks.PeakName)-1), Rivers.RiverName)) AS Mix
FROM Peaks
     JOIN Rivers ON RIGHT(Peaks.PeakName, 1) = LEFT(Rivers.RiverName, 1)
ORDER BY Mix;




 