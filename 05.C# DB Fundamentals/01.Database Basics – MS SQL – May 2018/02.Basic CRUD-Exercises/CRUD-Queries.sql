/* ******************************************
22. All Mountain Peaks
*********************************************/
SELECT   PeakName
  FROM   Peaks
ORDER BY PeakName ASC
/* ******************************************
23. Biggest Countries by Population
*********************************************/
SELECT TOP(30) CountryName,Population 
  FROM Countries
 WHERE ContinentCode = (SELECT ContinentCode FROM Continents
 WHERE ContinentName = 'Europe')
 ORDER BY Population DESC,CountryName
 /* ******************************************
24. Countries and Currency (Euro / Not Euro)
*********************************************/
SELECT CountryName,CountryCode,Currency =  
      CASE CurrencyCode  
         WHEN 'EUR' THEN 'Euro'
         ELSE 'Not Euro'  
      END 
 FROM Countries
ORDER BY CountryName