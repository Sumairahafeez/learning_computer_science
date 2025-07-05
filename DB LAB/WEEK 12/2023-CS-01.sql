--Query1--
SELECT * FROM Customers c
LEFT JOIN  (SELECT CustomerID,OrderID,OrderDate FROM Orders) o
ON c.CustomerID = o.CustomerID
ORDER BY o.OrderID,o.OrderDate
--QUERY 2--
SELECT * FROM Customers c
LEFT JOIN  (SELECT CustomerID,OrderID,OrderDate FROM Orders WHERE OrderDate = NULL) o
ON c.CustomerID = o.CustomerID
ORDER BY o.OrderID,o.OrderDate
--QUERY 3--
SELECT * FROM Customers c
LEFT JOIN  (SELECT CustomerID,OrderID,OrderDate FROM Orders WHERE MONTH(OrderDate) = '06' AND YEAR(OrderDate)='1997') o
ON c.CustomerID = o.CustomerID
ORDER BY o.OrderID,o.OrderDate
--QUERY 4--
SELECT ContactName, (SELECT COUNT(*) as TotalORDERS FROM Orders WHERE c.CustomerID= CustomerID  ) FROM Customers c
--QUERY 5--
SELECT 
    e.EmployeeID, e.FirstName,e.LastName
FROM 
    Employees e
CROSS JOIN 
    (SELECT 1 AS num UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5) AS nums;
	--QUERY 6--
	SELECT * FROM Products WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products)
	--QUERY 7--
	SELECT MAX(UnitPrice) as price FROM Products WHERE  UnitPrice<(SELECT MAX(UnitPrice) FROM Products)
	--QUERY 8--
	SELECT 
    e.EmployeeID,
    d.Date
FROM 
    Employees e
CROSS JOIN 
    (
        SELECT DATEADD(day, number, '1996-04-07') AS Date
        FROM master..spt_values
        WHERE type = 'P'
        AND DATEADD(day, number, '1996-04-07') <= '1997-04-08'
    ) AS d
ORDER BY 
    e.EmployeeID, d.Date;
--QUERY 9--
SELECT 
    c.CustomerID,
    (
        SELECT COUNT(*)
        FROM Orders o
        WHERE o.CustomerID = c.CustomerID
    ) AS TotalOrders,
    (
        SELECT SUM(od.Quantity)
        FROM Orders o
        INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
        WHERE o.CustomerID = c.CustomerID
    ) AS TotalQuantity
FROM 
    Customers c
WHERE 
    c.Country = 'USA';
	--QUERY 10--
	SELECT 
    c.CustomerID,
    c.ContactName,
    o.OrderID,
    o.OrderDate
FROM 
    Customers c
LEFT JOIN 
    (
        SELECT 
            OrderID, 
            CustomerID, 
            OrderDate 
        FROM 
            Orders 
        WHERE 
            CONVERT(DATE, OrderDate) = '1997-07-04'
    ) AS o ON c.CustomerID = o.CustomerID;

	--QUERY 11--
	SELECT 
    CONCAT(e1.FirstName, ' ', e1.LastName) AS EmployeeName,
    DATEDIFF(YEAR, e1.BirthDate, GETDATE()) AS Age,
    DATEDIFF(YEAR, e2.BirthDate, GETDATE()) AS ManagerAge
FROM 
    Employees e1
LEFT JOIN 
    Employees e2 ON e1.EmployeeID = e2.EmployeeID;
	--QUERY 12--
	SELECT 
    ProductName
FROM 
    Products
WHERE 
    ProductID IN (
        SELECT 
            ProductID
        FROM 
            [Order Details]
        WHERE 
            OrderID IN (
                SELECT 
                    OrderID
                FROM 
                    Orders
                WHERE 
                    CONVERT(DATE, OrderDate) = '1997-08-08'
            )
    );
	--QUERY 13--
	SELECT 
    ShipAddress AS Address,
    ShipCity AS City,
    ShipCountry AS Country
FROM 
    Orders
WHERE 
    EmployeeID = (
        SELECT 
            EmployeeID 
        FROM 
            Employees 
        WHERE 
            FirstName = 'Anne'
    )
    AND ShippedDate > RequiredDate;
	--QUERY 14--
	SELECT DISTINCT
    c.Country
FROM
    Customers c
JOIN
    Orders o ON c.CustomerID = o.CustomerID
JOIN
    [Order Details] od ON o.OrderID = od.OrderID
JOIN
    Products p ON od.ProductID = p.ProductID
WHERE
    p.CategoryID = (
        SELECT 
            CategoryID
        FROM 
            Categories
        WHERE 
            CategoryName = 'Beverages'
    );






