SELECT TOP 10 HireDate, Title FROM Employees
Where Title IS NOT  NULL
ORDER BY HireDate DESC, Title ASC;
/*SECOND QUERY */
SELECT TOP 10 categoryID FROM Categories
Where CategoryID>0
ORDER BY CategoryID DESC
/*THIRD QUERY*/
SELECT TOP 10 City,Country FROM Customers
Where City IS NOT NULL
ORDER BY City Desc, Country ASC
/*IT IS ACTUALLY IMPLEMENTABLE ON THIRD QUERY