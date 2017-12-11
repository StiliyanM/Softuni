SELECT c.Name AS CategoryName,
		COUNT(e.Id) AS [Employees Number]
 FROM Categories c
LEFT JOIN Departments d ON d.Id = c.DepartmentId
JOIN Employees e ON e.DepartmentId = d.Id
GROUP BY c.Id, c.Name
ORDER BY CategoryName

SELECT c.Name,COUNT(*) FROM Reports r
LEFT JOIN Categories c ON c.Id = r.CategoryId
JOIN Employees e ON e.Id = r.EmployeeId
GROUP BY c.Id,c.Name
ORDER BY c.Name

SELECT * FROM Categories