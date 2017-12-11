SELECT d.Name AS [Department Name],
		c.Name AS [Category Name],
		 (CAST(COUNT(*) AS DECIMAL(15,2))/(SELECT 
		COUNT(*)
		 FROM Departments dd
		JOIN Categories c ON c.DepartmentId = dd.Id
		JOIN Reports r ON r.CategoryId = c.Id
		WHERE dd.Name = d.Name) * 100)
		 AS Percentage
FROM Departments d
JOIN Categories c ON c.DepartmentId = d.Id
JOIN Reports r ON r.CategoryId = c.Id
GROUP BY d.Name, c.Name
ORDER BY [Department Name],[Category Name], Percentage


