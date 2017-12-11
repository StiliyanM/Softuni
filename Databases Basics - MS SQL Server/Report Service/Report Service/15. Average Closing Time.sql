SELECT d.Name AS [Department Name],
		 ISNULL(AVG(DATEDIFF(DAY,r.OpenDate,r.CloseDate)), 0) AS [Average Duration]
FROM Departments d
JOIN Categories c ON c.DepartmentId = d.Id
JOIN Reports r ON r.CategoryId = c.Id
GROUP BY d.Name
ORDER BY [Department Name]
